using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class FonixPermissions : Form
    {
        // Lépésszámláló
        public static int stepCounter;

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

        // Dropshadow az ablak körül
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        public FonixPermissions()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Felület betöltése
        private void Fonix3_Load(object sender, EventArgs e)
        {
            GC.Collect();
            stepCounter = 0;
        }

        // Program tálcára tétele
        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        // Program teljes bezárása
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        // Visszalépés a főmenübe
        private void ReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            Dispose();
        }

        // Visszalépés az elöző lépéshez
        private void PrevoiusStepGroupButton_Click(object sender, EventArgs e)
        {
            stepCounter--;
            SetupStepGroup();
        }

        // Továbblépés a következő lépéshez
        private void NextStepGroupButton_Click(object sender, EventArgs e)
        {
            stepCounter++;
            SetupStepGroup();
        }

        // Az aktuális lépés megjelenítése
        private void SetupStepGroup()
        {
            switch (stepCounter)
            {
                case 0: // Felhasználó alap adatai
                    stepUserData.Visible = true;
                    stepFonix01.Visible = false;
                    checkTextEnable1.Visible = true;
                    checkTextEnable2.Visible = false;
                    backButton.Enabled = false;
                    break;

                case 1: // Főnix szakterületek
                    stepUserData.Visible = false;
                    stepFonix01.Visible = true;
                    stepFonix02.Visible = false;
                    checkTextEnable1.Visible = false;
                    checkTextEnable2.Visible = true;
                    checkTextEnable3.Visible = false;
                    backButton.Enabled = true;
                    break;

                case 2: // Főnix intézeti és országos hozzáférések
                    stepFonix01.Visible = false;
                    stepFonix02.Visible = true;
                    stepFinal.Visible = false;
                    checkTextEnable2.Visible = false;
                    checkTextEnable3.Visible = true;
                    checkTextEnable4.Visible = false;
                    nextButton.Enabled = true;
                    break;

                case 3: // Összesítés az igénylésről
                    DataSummary();
                    stepFonix02.Visible = false;
                    stepFinal.Visible = true;
                    checkTextEnable3.Visible = false;
                    checkTextEnable4.Visible = true;
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
            checkUsernameText.Text = usernameText.Text.Length > 0 ? usernameText.Text : "-";
            checkSpecialtyText.Text = specialtyText.Text;
            checkPostText.Text = postText.Text;
            checkOfficeText.Text = officeText.Text;
            checkNTGText.Text = ntgText.Text;

            // Szakterületek
            checkChooseSpecialtyText.Text = "";
            int specialtyCount = 0;

            foreach (string szakterulet in chooseSpecialtyText.CheckedItems)
            {
                checkChooseSpecialtyText.Text += (szakterulet + "; ");
                specialtyCount++;
            }

            // Intézeti hozzáférések
            checkLocalPermissions.Text = "";
            int instituteCount = 0;

            foreach (string intezetiHozzaferes in instituteText.CheckedItems)
            {
                checkLocalPermissions.Text += (intezetiHozzaferes + "; ");
                instituteCount++;
            }

            // Országos hozzáférések
            checkNationPermissions.Text = "";
            int nationalCount = 0;

            foreach (string orszagosHozzaferes in nationalText.CheckedItems)
            {
                checkNationPermissions.Text += (orszagosHozzaferes + "; ");
                nationalCount++;
            }

            // Adatok ellenőrzése, ha minden megfelelő PDF készítés engedélyezése, ellenkező esetben hiba megjelenítése
            createButton.Enabled = SummaryChecker.CheckDatas(lastNameText.Text, firstNameText.Text, rankText.Text, specialtyText.Text, postText.Text, officeText.Text, ntgText.Text) && specialtyCount > 0 && instituteCount > 0 && nationalCount > 0;
            errorText.Visible = !createButton.Enabled;
            errorPicture.Visible = !createButton.Enabled;
        }

        private void CreatePDF(object sender, EventArgs e)
        {
            // Fájl mentés neve
            savePDF.FileName = $"{LoadingSplashScreen.dayToday} - {lastNameText.Text} {firstNameText.Text} FŐNIX3 jogosultság igénylése";

            // Fájl mentésének helye, ha mégsézik akkor kilép a mentésből
            if (savePDF.ShowDialog() != DialogResult.OK) return;

            // Mentés folyamatban kép megjelenítése
            new LoadingSave(this);

            // Eredeti fájl helye
            string originalFilePath = $"{LoadingSplashScreen.userProfilePath}FonixPermissions.docx";

            // Kimeneti fájl helye
            LoadingSave.savedFileLocation = savePDF.FileName;

            // Adatok elküldése a Documentum szerkeztőnek
            DocumentEditor.lastName = checkLastNameText.Text;
            DocumentEditor.firstName = checkFirstNameText.Text;
            DocumentEditor.rank = RankConverter.GetShortRank(checkRankText.Text);
            DocumentEditor.username = checkUsernameText.Text;
            DocumentEditor.specialty = checkSpecialtyText.Text;
            DocumentEditor.post = checkPostText.Text;
            DocumentEditor.office = checkOfficeText.Text;
            DocumentEditor.ntg = checkNTGText.Text;

            // Szolgáltatás alapú
            DocumentEditor.specialitys = checkChooseSpecialtyText.Text;
            DocumentEditor.localPermissions = checkLocalPermissions.Text;
            DocumentEditor.nationPermissions = checkNationPermissions.Text;

            try
            {
                // Dokumentum átszerkeztése majd elmentése az új helyre
                DocumentEditor.Create(originalFilePath, LoadingSave.savedFileLocation, "Fonix");

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