using SKFB_ISZR.Tools;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class CameraPermissions : Form
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

        public CameraPermissions()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Felület betöltése
        private void CameraPermissionsForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
            stepCounter = 0;
        }

        // Program teljes bezárása
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        // Program tálcára tétele
        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        // Visszalépés a főmenübe
        private void ReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            Dispose();
        }

        // Visszalépés az elöző lépéshez
        private void PreviousStepGroupButton_Click(object sender, EventArgs e)
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
                    step01.Visible = true;
                    step02.Visible = false;
                    checkTextEnable1.Visible = true;
                    checkTextEnable2.Visible = false;
                    backButton.Enabled = false;
                    nextButton.Enabled = true;
                    break;

                case 1: // Igényelt Hikcentrál jogosultságok
                    step01.Visible = false;
                    step02.Visible = true;
                    step03.Visible = false;
                    checkTextEnable1.Visible = false;
                    checkTextEnable2.Visible = true;
                    checkTextEnable3.Visible = false;
                    backButton.Enabled = true;
                    nextButton.Enabled = true;
                    break;

                case 2: // Összesítés az igénylésről
                    DataSummary();
                    step02.Visible = false;
                    step03.Visible = true;
                    checkTextEnable2.Visible = false;
                    checkTextEnable3.Visible = true;
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

            // Felhasználónév generálása
            byte[] tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(lastNameText.Text + "." + firstNameText.Text);
            string asciiStr = System.Text.Encoding.UTF8.GetString(tempBytes);
            generatedUsernameText.Text = asciiStr.ToLower();

            // Jogosultság
            checkPermissionTypeText.Text = viewer.Checked ? "Megtekintő" : "Felügyelő";

            // Helyszínek kitakarítása, mielött duplikáció lépne fel
            checkPlacesText.Text = "";
            int placeCount = 0;

            foreach (string place in places.CheckedItems)
            {
                checkPlacesText.Text += $"{place}; ";
                placeCount++;
            }

            // Adatok ellenőrzése, ha minden megfelelő PDF készítés engedélyezése, ellenkező esetben hiba megjelenítése
            createButton.Enabled = SummaryChecker.CheckDatas(lastNameText.Text, firstNameText.Text, rankText.Text, specialtyText.Text, postText.Text, officeText.Text, ntgText.Text) && placeCount > 0;
            errorText.Visible = !createButton.Enabled;
            errorPicture.Visible = !createButton.Enabled;
        }

        // Szolgálati jegy elkészítése PDF-ben a kért mappába
        private void CreatePDF(object sender, EventArgs e)
        {
            // Fájl mentés neve
            savePDF.FileName = $"{LoadingSplashScreen.dayToday} - {lastNameText.Text} {firstNameText.Text} kamera jogosultság igénylése";

            // Fájl mentésének helye, ha mégsézik akkor kilép a mentésből
            if (savePDF.ShowDialog() != DialogResult.OK) return;

            // Mentés folyamatban kép megjelenítése
            new LoadingSave(this);

            // Eredeti fájl helye
            string originalFilePath = $"{LoadingSplashScreen.userProfilePath}CameraPermission.docx";

            // Kimeneti fájl helye
            LoadingSave.savedFileLocation = savePDF.FileName;

            // Adatok elküldése a Documentum szerkeztőnek
            DocumentEditor.lastName = checkLastNameText.Text;
            DocumentEditor.firstName = checkFirstNameText.Text;
            DocumentEditor.rank = RankConverter.Short(checkRankText.Text);
            DocumentEditor.specialty = checkSpecialtyText.Text;
            DocumentEditor.post = checkPostText.Text;
            DocumentEditor.office = checkOfficeText.Text;
            DocumentEditor.ntg = checkNTGText.Text;

            // Szolgáltatás alapú
            DocumentEditor.generatedUsername = generatedUsernameText.Text;
            DocumentEditor.permissionType = checkPermissionTypeText.Text;
            DocumentEditor.permissionList = checkPlacesText.Text;

            try
            {
                // Dokumentum átszerkeztése majd elmentése az új helyre
                DocumentEditor.Create(originalFilePath, LoadingSave.savedFileLocation, "CameraPermissions");

                // Dokumentum elkésítésének sikerességének megjelenítése
                LoadingSave.fileSavedTitle.Text = "Fájl mentése sikeresen befejezödött";
                LoadingSave.fileSavedInfo.Text = "A generált fájl mostmár robotzsaruzható";
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

        private void OnlyNumberic(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}