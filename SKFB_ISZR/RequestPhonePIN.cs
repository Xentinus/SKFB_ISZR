using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class RequestPhonePIN : Form
    {
        // Lépésszámláló
        public static int stepCounter;

        // Elérhető PINek tárolója
        public string availablePINs;

        // Elérhető PINek elérési útvonala
        public string availablePINsLocation = AppDomain.CurrentDomain.BaseDirectory + "Database\\AvailablePINs.txt";

        // Lekerekített sarok
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        private const int CS_DropShadow = 0x00020000;

        // Dropshadow az ablak körül
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        public RequestPhonePIN()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Felület betöltése
        private void TelefonPIN_Load(object sender, EventArgs e)
        {
            GC.Collect();
            stepCounter = 0;
        }

        // Program teljes bezárása
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        // Program tálcára tétele
        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        // Visszalépés a főmenübe
        private void ReturnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            Dispose();
        }

        // Továbblépés a következő lépéshez
        private void NextStepGroupButton_Click(object sender, EventArgs e)
        {
            stepCounter++;
            SetupStepGroup();
        }

        // Visszalépés az elöző lépéshez
        private void PreviousStepGroupButton_Click(object sender, EventArgs e)
        {
            stepCounter--;
            SetupStepGroup();
        }

        // Az aktuális lépés megjelenítése
        private void SetupStepGroup()
        {
            switch (stepCounter)
            {
                case 0: // Alap információk afelhasználóról
                    step01.Visible = true;
                    step02.Visible = false;
                    checkTextEnable1.Visible = true;
                    checkTextEnable2.Visible = false;
                    backButton.Enabled = false;
                    nextButton.Enabled = true;

                    break;

                case 1: // Összesítés az adatokról
                    DataSummary();
                    step01.Visible = false;
                    step02.Visible = true;
                    checkTextEnable1.Visible = false;
                    checkTextEnable2.Visible = true;
                    backButton.Enabled = true;
                    nextButton.Enabled = false;
                    break;
            }
        }

        // Bevitt adatok ellenőrzése, amennyiben megfelelt PDF nyomtatás lehetősége áll fenn
        private void DataSummary()
        {
            // Alap adatok
            checkLastNameText.Text = lastNameText.Text;
            checkFirstNameText.Text = firstNameText.Text;
            checkRankText.Text = rankText.Text;
            checkSpecialtyText.Text = specialtyText.Text;
            checkPostText.Text = postText.Text;
            checkOfficeText.Text = officeText.Text;
            checkNTGText.Text = ntgText.Text;

            // Elérhető PINek betöltése a fájlból
            StreamReader availablePINsFile = new StreamReader(availablePINsLocation);
            availablePINs = availablePINsFile.ReadToEnd();
            availablePINsFile.Close();

            // Az első PIN lekérdezése
            string firstAvailablePIN = availablePINs.Substring(0, availablePINs.IndexOf('\n') + 1);

            // Az első PIN törlése a lementett PINekből
            availablePINs = Regex.Replace(availablePINs, firstAvailablePIN, "");

            // Adatok ellenőrzése, ha minden megfelelő PDF készítés engedélyezése, ellenkező esetben hiba megjelenítése
            createButton.Enabled = SummaryChecker.CheckDatas(lastNameText.Text, firstNameText.Text, rankText.Text, specialtyText.Text, postText.Text, officeText.Text, ntgText.Text);
            checkPINText.Text = createButton.Enabled ? firstAvailablePIN : "******";
            errorText.Visible = !createButton.Enabled;
            errorPicture.Visible = !createButton.Enabled;

            if (createButton.Enabled)
            {
                // Az elérhető PINek fájl újraírása (kitörli az első PIN-t)
                StreamWriter file = new StreamWriter(availablePINsLocation, false);
                file.Write(availablePINs);
                file.Close();
            }
        }

        private void CreatePDFButton_Click(object sender, EventArgs e)
        {
            // Fájl mentés neve
            savePDF.FileName = $"{LoadingSplashScreen.dayToday} - {lastNameText.Text} {firstNameText.Text} külső telefonáláshoz PIN igénylése";

            // Fájl mentésének helye, ha mégsézik akkor kilép a mentésből
            if (savePDF.ShowDialog() != DialogResult.OK) return;

            // Mentés folyamatban kép megjelenítése
            new LoadingSave(this);

            // Eredeti fájl helye
            string originalFilePath = $"{LoadingSplashScreen.userProfilePath}RequestPhonePIN.docx";

            // Kimeneti fájl helye
            LoadingSave.savedFileLocation = savePDF.FileName;

            // Adatok elküldése a Documentum szerkeztőnek
            DocumentEditor.lastName = checkLastNameText.Text;
            DocumentEditor.firstName = checkFirstNameText.Text;
            DocumentEditor.rank = RankConverter.GetShortRank(checkRankText.Text);
            DocumentEditor.specialty = checkSpecialtyText.Text;
            DocumentEditor.post = checkPostText.Text;
            DocumentEditor.office = checkOfficeText.Text;
            DocumentEditor.ntg = checkNTGText.Text;

            // Szolgáltatás alapú
            DocumentEditor.generatedPIN = (checkPINText.Text).Substring(0, 6);

            try
            {
                // Dokumentum átszerkeztése majd elmentése az új helyre
                DocumentEditor.Create(originalFilePath, LoadingSave.savedFileLocation, "PIN");

                // Dokumentum elkésítésének sikerességének megjelenítése
                LoadingSave.fileSavedTitle.Text = "Fájl mentése sikeresen befejezödött";
                LoadingSave.fileSavedInfo.Text = "A generált fájl mostmár robotzsaruzható az 5-ös főszámon";
            }
            catch
            {
                // A dokumentum elkészítésének sikertelenségének megjelenítése
                LoadingSave.fileSavedTitle.Text = "Fájl mentése sikertelen volt";
                LoadingSave.fileSavedInfo.Text = "Hiba történt az elkészítés közben, próbáld újra!";
            }
            finally
            {
                // Mentés utáni memória takarítás
                savePDF.Dispose();
            }
        }

        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}