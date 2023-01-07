using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using SKFB_ISZR.Tools;
using SKFB_ISZR.Tools.Permissions;

namespace SKFB_ISZR
{
    public partial class WindowsPermissions : Form
    {
        // Lépésszámláló
        public static int stepCounter;

        // Új user vagy régi?
        public static bool newUser = true;

        // Új szkterület vagy többlet jogosultság
        public static bool newSzakterulet = false;

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

        public WindowsPermissions()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Lezárt pipák státusz változtatásának tiltása
        private void LockCheckState(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Indeterminate) e.NewValue = CheckState.Indeterminate;
        }

        // Felület betöltése
        private void Windows_Load(object sender, EventArgs e)
        {
            stepCounter = 0;
        }

        // Program teljes bezárása
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Program tálcára tétele
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Visszalépés a főmenübe
        private void ReturnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            this.Dispose();
        }

        // Visszalépés az elöző lépéshez
        private void PreviousStepGroupButton_Click(object sender, EventArgs e)
        {
            if (stepCounter == 3 && newUser)
            {
                stepCounter -= 2;
            }
            else
            {
                stepCounter--;
            }
            SetupStepGroup();
        }

        // Továbblépés a következő lépéshez
        private void NextStepGroupButton_Click(object sender, EventArgs e)
        {
            if (stepCounter == 1 && newUser)
            {
                stepCounter += 2;
            }
            else
            {
                stepCounter++;
            }
            SetupStepGroup();
        }

        // Új felhasználó kiválasztása
        private void NewUserTypeButton_Click(object sender, EventArgs e)
        {
            newUser = true;
            newSzakterulet = false;
            usernameText.Text = "";
            stepCounter++;
            SetupStepGroup();
        }

        // Régi felhasználó kiválasztása
        private void OldUserTypeButton_Click(object sender, EventArgs e)
        {
            newUser = false;
            newSzakterulet = false;
            usernameText.Text = "";
            stepCounter++;
            SetupStepGroup();
        }

        private void OldUserNewSzakterulet_Click(object sender, EventArgs e)
        {
            newUser = true;
            newSzakterulet = true;
            usernameText.Text = "";
            stepCounter++;
            SetupStepGroup();
        }

        // Alapértelmezett nyomtató igénylése
        private void DefaultPrinterYes_Click(object sender, EventArgs e)
        {
            step04Question.Visible = false;
            step04PrinterList.Visible = true;
            nextButton.Enabled = true;
        }

        // Nincs igény alapértelmezett nyomtatóra
        private void DefaultPrinterNo_Click(object sender, EventArgs e)
        {
            stepCounter++;
            SetupStepGroup();
        }

        // Jogosultsági lista resetelése ha a Szakterületi csoport megváltozik
        private void SelectedGroupChanged_ResetList(object sender, EventArgs e)
        {
            choosePermissionsText.Items.Clear();
            for (int i = 0; i < defaultPermissionsList.Items.Count; i++)
            {
                choosePermissionsText.Items.Add(defaultPermissionsList.Items[i].ToString(), CheckState.Unchecked);
            }
        }

        // Csoport elemeinek feltöltése a kiválasztott szakterület alapján
        private void ChoosedSpecialityFromList(object sender, EventArgs e)
        {
            // Hozzáadás elött tisztítás
            groupText.Items.Clear();

            // Szakterület alapján csoportok hozzáadása
            ClassGroups.GetGroups(specialtyText.Text);

            foreach (object specialityGroup in ClassGroups.specialityGroups.Items)
            {
                groupText.Items.Add(specialityGroup);
            }
        }

        // Jogosultságok lezárása
        private void LockGroupPermissions()
        {
            // Osztály és csoport jogosultságok lekérdezése
            string groupPermissions = GetGroupPermissions();

            // Jogosultságok soronkénti elhelyezése
            string linedPermissions = Regex.Replace(groupPermissions, @"\; ", System.Environment.NewLine);

            // Beosztás alapján lockolni az alapértelmezett jgoosultságokat
            foreach (string permissionName in linedPermissions.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                // Jogosultságok átkonvertálása családbaráttá
                string familyFriendlyPermissionName = PermissionConverter.ReturnUserFriendlyName(permissionName);

                // Listában nem szereplő jogosultságok átugrása (pl skfb-users)
                if (familyFriendlyPermissionName == string.Empty) continue;

                // Alap jogosultság eltávolítása a listából majd hozzáadása lezártként
                try
                {
                    choosePermissionsText.Items.Remove(familyFriendlyPermissionName);
                }
                finally
                {
                    if (!choosePermissionsText.Items.Contains(familyFriendlyPermissionName))
                    {
                        choosePermissionsText.Items.Add(familyFriendlyPermissionName, CheckState.Indeterminate);
                    }
                }
            }
        }

        // Osztály és csoport jogosultságok lekérdezése
        private string GetGroupPermissions()
        {
            // Osztály jogosultságok lekérdezése
            string groupPermissions = ClassPermissions.getPermissions(specialtyText.Text);

            // Csoport jogosultságok lekérdezése
            groupPermissions += GroupPermissions.GetPermissions(specialtyText.Text, groupText.Text);
            return groupPermissions + "; ";
        }

        // Egyedi jogosultságok kimentése
        private string GetPersonalPermissions()
        {
            string personalPermissions = "";
            // Csak egyedi jogosultságok kimentése
            for (int i = 0; i < choosePermissionsText.Items.Count; i++)
            {
                // Csak nem lezárt, és pipált jogosultságok lementése
                if (choosePermissionsText.GetItemCheckState(i) == CheckState.Checked)
                {
                    // Családbarát jogosultságok átkonvertálása AD-s jogosultsággá
                    string personalPermission = PermissionConverter.ReturnADPermissions(choosePermissionsText.Items[i].ToString());
                    personalPermissions += personalPermission + "; ";
                }
            }
            return personalPermissions;
        }

        // Nyomtatók hozzáadása
        private string GetPrinters()
        {
            string printersPermissions = "";
            for (int i = 0; i < printersText.Items.Count; i++)
            {
                if (printersText.GetItemCheckState(i) == CheckState.Checked)
                {
                    string printerPermission = printersText.Items[i].ToString();
                    printersPermissions += printerPermission + "; ";
                }
            }
            return printersPermissions;
        }

        // Az aktuális lépés megjelenítése
        private void SetupStepGroup()
        {
            switch (stepCounter)
            {
                case 0: // Felhasználó típus választása
                    step01.Visible = true;
                    step02.Visible = false;
                    checkTextEnable1.Visible = true;
                    checkTextEnable2.Visible = false;
                    backButton.Enabled = false;
                    nextButton.Enabled = false;
                    break;

                case 1: // Felhasználó alap adatai
                    usernameText.Enabled = !newUser || newSzakterulet;
                    step01.Visible = false;
                    step02.Visible = true;
                    step03PermissionList.Visible = false;
                    step04Question.Visible = false;
                    checkTextEnable1.Visible = false;
                    checkTextEnable2.Visible = true;
                    checkTextEnable3.Visible = false;
                    checkTextEnable4.Visible = false;
                    checkTextEnable5.Visible = false;
                    backButton.Enabled = true;
                    nextButton.Enabled = true;
                    break;

                case 2: // Jogosultságok kiválasztása
                    LockGroupPermissions();
                    step02.Visible = false;
                    step03PermissionList.Visible = true;
                    step04Question.Visible = false;
                    step04PrinterList.Visible = false;
                    checkTextEnable2.Visible = false;
                    checkTextEnable3.Visible = true;
                    checkTextEnable4.Visible = false;
                    break;

                case 3: // Nyomtatók kiválasztása
                    step02.Visible = false;
                    step03PermissionList.Visible = false;
                    step04Question.Visible = true;
                    step05.Visible = false;
                    checkTextEnable2.Visible = false;
                    checkTextEnable3.Visible = false;
                    checkTextEnable4.Visible = true;
                    checkTextEnable5.Visible = false;
                    nextButton.Enabled = true;
                    break;

                case 4: // Összesítés az igénylésről
                    DataSummary();
                    step04Question.Visible = false;
                    step04PrinterList.Visible = false;
                    step05.Visible = true;
                    checkTextEnable4.Visible = false;
                    checkTextEnable5.Visible = true;
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
            checkGroupText.Text = groupText.Text;
            checkOfficeText.Text = officeText.Text;
            checkNTGText.Text = ntgText.Text;

            // Jogosultság
            checkUserTypeText.Text = UserType();

            // Felhasználói típus alapján jogosultság megjelenítése
            try
            {
                checkPermissionsText.Text = newUser ? GetPersonalPermissions() + GetGroupPermissions() + GetPrinters() : GetPersonalPermissions() + GetPrinters();
            }
            catch
            {
                checkPermissionsText.Text = "";
            }

            createButton.Enabled = SummaryChecker.CheckDatas(lastNameText.Text, firstNameText.Text, rankText.Text, specialtyText.Text, groupText.Text, officeText.Text, ntgText.Text, checkPermissionsText.Text);
            errorText.Visible = !createButton.Enabled;
            errorPicture.Visible = !createButton.Enabled;
        }

        private string UserType()
        {
            if (newUser)
            {
                if (newSzakterulet)
                {
                    return "Meglévő felhasználó új szakterületen";
                }
                else
                {
                    return "Új felhasználó";
                }
            }
            else
            {
                return "Meglévő felhasználó számára többletjogosultság";
            }
        }

        private void CreatePDF(object sender, EventArgs e)
        {
            // Fájl mentés neve
            savePDF.FileName = $"{LoadingSplashScreen.dayToday} - {lastNameText.Text} {firstNameText.Text} windows jogosultság igénylése";

            // Fájl mentésének helye, ha mégsézik akkor kilép a mentésből
            if (savePDF.ShowDialog() != DialogResult.OK) return;

            // Mentés folyamatban kép megjelenítése
            new LoadingSave(this);

            // Eredeti fájl helye
            string originalFilePath = $"{LoadingSplashScreen.userProfilePath}WindowsPermissions.docx";

            // Kimeneti fájl helye
            LoadingSave.savedFileLocation = savePDF.FileName;

            // Adatok elküldése a Documentum szerkeztőnek
            DocumentEditor.lastName = checkLastNameText.Text;
            DocumentEditor.firstName = checkFirstNameText.Text;
            DocumentEditor.rank = RankConverter.Short(checkRankText.Text);
            DocumentEditor.username = checkUsernameText.Text;
            DocumentEditor.specialty = checkSpecialtyText.Text;
            DocumentEditor.group = checkGroupText.Text;
            DocumentEditor.office = checkOfficeText.Text;
            DocumentEditor.ntg = checkNTGText.Text;

            // Szolgáltatás alapú
            DocumentEditor.permissionType = checkUserTypeText.Text;
            DocumentEditor.permissionList = checkPermissionsText.Text;

            try
            {
                // Dokumentum átszerkeztése majd elmentése az új helyre
                DocumentEditor.Create(originalFilePath, LoadingSave.savedFileLocation, "Windows");

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

        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}