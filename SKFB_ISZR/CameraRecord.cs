using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class CameraRecord : Form
    {
        // Lépésszámláló
        public static int stepCounter;

        // Érvényes e minden dátum
        public static bool GoodRecordDates = true;

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

        public CameraRecord()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Felület betöltése
        private void CameraRecordForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
            stepCounter = 0;

            // Kezdő időpont minimum dátumának beállítása (max 35 nap)
            recordTimeStart01.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart02.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart03.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart04.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart05.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart06.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart07.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart08.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart09.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeStart10.MinDate = LoadingSplashScreen.minRecordDay;

            // Kezdő időpont maximum dátumának beállítása (ma)
            recordTimeStart01.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart02.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart03.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart04.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart05.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart06.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart07.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart08.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart09.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeStart10.MaxDate = LoadingSplashScreen.maxRecordDay;

            // Vége időpont minimum dátumának beállítása (max 35 nap)
            recordTimeEnd01.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd02.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd03.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd04.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd05.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd06.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd07.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd08.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd09.MinDate = LoadingSplashScreen.minRecordDay;
            recordTimeEnd10.MinDate = LoadingSplashScreen.minRecordDay;

            // Vége időpont maximum dátumának beállítása (ma)
            recordTimeEnd01.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd02.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd03.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd04.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd05.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd06.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd07.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd08.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd09.MaxDate = LoadingSplashScreen.maxRecordDay;
            recordTimeEnd10.MaxDate = LoadingSplashScreen.maxRecordDay;
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
                case 0: // Alap adatok a felhasználóról
                    step01.Visible = true;
                    step02.Visible = false;
                    checkTextEnable1.Visible = true;
                    checkTextEnable2.Visible = false;
                    backButton.Enabled = false;
                    nextButton.Enabled = true;
                    break;

                case 1: // A felvételek adatai
                    step01.Visible = false;
                    step02.Visible = true;
                    step03.Visible = false;
                    checkTextEnable1.Visible = false;
                    checkTextEnable2.Visible = true;
                    checkTextEnable3.Visible = false;
                    backButton.Enabled = true;
                    nextButton.Enabled = true;
                    GoodRecordDates = true;
                    break;

                case 2: // Összesítés az adatokról
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
            // Alap adatok kiírása a véglegesítőbe
            checkLastNameText.Text = lastNameText.Text;
            checkFirstNameText.Text = firstNameText.Text;
            checkRankText.Text = rankText.Text;
            checkSpecialtyText.Text = specialtyText.Text;
            checkPostText.Text = postText.Text;
            checkOfficeText.Text = officeText.Text;
            checkNTGText.Text = ntgText.Text;

            // Kamera felvétel adatai
            checkRecordReasonText.Text = recordReasonText.Text;

            // Adattábla letisztítása
            recordTable.Rows.Clear();

            // Rögzítések hozzáadása az adattáblához
            if (!String.IsNullOrWhiteSpace(cameraName01.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName01.Text, recordTimeStart01.Text, recordTimeEnd01.Text);
            if (!String.IsNullOrWhiteSpace(cameraName02.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName02.Text, recordTimeStart02.Text, recordTimeEnd02.Text);
            if (!String.IsNullOrWhiteSpace(cameraName03.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName03.Text, recordTimeStart03.Text, recordTimeEnd03.Text);
            if (!String.IsNullOrWhiteSpace(cameraName04.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName04.Text, recordTimeStart04.Text, recordTimeEnd04.Text);
            if (!String.IsNullOrWhiteSpace(cameraName05.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName05.Text, recordTimeStart05.Text, recordTimeEnd05.Text);
            if (!String.IsNullOrWhiteSpace(cameraName06.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName06.Text, recordTimeStart06.Text, recordTimeEnd06.Text);
            if (!String.IsNullOrWhiteSpace(cameraName07.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName07.Text, recordTimeStart07.Text, recordTimeEnd07.Text);
            if (!String.IsNullOrWhiteSpace(cameraName08.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName08.Text, recordTimeStart08.Text, recordTimeEnd08.Text);
            if (!String.IsNullOrWhiteSpace(cameraName09.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName09.Text, recordTimeStart09.Text, recordTimeEnd09.Text);
            if (!String.IsNullOrWhiteSpace(cameraName10.Text)) AddCameraToRecordTable(recordTable.Rows.Count, cameraName10.Text, recordTimeStart10.Text, recordTimeEnd10.Text);

            // Adatok ellenőrzése, ha minden megfelelő PDF készítés engedélyezése, ellenkező esetben hiba megjelenítése
            createButton.Enabled = SummaryChecker.CheckDatas(lastNameText.Text, firstNameText.Text, rankText.Text, specialtyText.Text, postText.Text, officeText.Text, ntgText.Text) && recordTable.Rows.Count > 0 && GoodRecordDates;
            errorText.Visible = !createButton.Enabled;
            errorPicture.Visible = !createButton.Enabled;
        }

        // Egy felvétel hozzáadása az adattáblához
        private void AddCameraToRecordTable(int tableLineCount, string tableCameraName, string tableTimeStart, string tableTimeEnd)
        {
            DateTime checkStart = DateTime.Parse(tableTimeStart);
            DateTime checkEnd = DateTime.Parse(tableTimeEnd);

            if (checkStart > checkEnd)
            {
                recordTable.Rows.Add("HIBÁS!", tableCameraName, tableTimeStart, tableTimeEnd);
                GoodRecordDates = false;
            }
            else
            {
                recordTable.Rows.Add(tableLineCount + 1, tableCameraName, tableTimeStart, tableTimeEnd);
            }
        }

        private void CreatePDF(object sender, EventArgs e)
        {
            // Fájl mentés neve
            int endString = checkRecordReasonText.Text.Length > 15 ? 15 : checkRecordReasonText.Text.Length;
            savePDF.FileName = $"{LoadingSplashScreen.dayToday} - {checkRecordReasonText.Text.Substring(0, endString)} kameraképének lementése";

            // Fájl mentésének helye, ha mégsézik akkor kilép a mentésből
            if (savePDF.ShowDialog() != DialogResult.OK) return;

            // Mentés folyamatban kép megjelenítése
            new LoadingSave(this);

            // Eredeti fájl helye
            string originalFilePath = $"{LoadingSplashScreen.userProfilePath}CameraRecord.docx";

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
            DocumentEditor.recordReason = checkRecordReasonText.Text;

            string recordLineCount = "";
            string recordCameraName = "";
            string recordTimeStart = "";
            string recordTimeEnd = "";

            for (int i = 0; i < recordTable.Rows.Count; i++) // Rows
            {
                for (int j = 0; j < recordTable.Columns.Count; j++)
                {
                    if (j == 0) recordLineCount += ((i + 1) + Environment.NewLine); // count
                    if (j == 1) recordCameraName += (recordTable.Rows[i].Cells[1].Value.ToString() + Environment.NewLine); // camera name
                    if (j == 2) recordTimeStart += (recordTable.Rows[i].Cells[2].Value.ToString() + Environment.NewLine); // camera start
                    if (j == 3) recordTimeEnd += (recordTable.Rows[i].Cells[3].Value.ToString() + Environment.NewLine); // camera end
                }
            }

            DocumentEditor.recordLineCount = recordLineCount;
            DocumentEditor.recordCameraName = recordCameraName;
            DocumentEditor.recordTimeStart = recordTimeStart;
            DocumentEditor.recordTimeEnd = recordTimeEnd;

            try
            {
                // Dokumentum átszerkeztése majd elmentése az új helyre
                DocumentEditor.Create(originalFilePath, LoadingSave.savedFileLocation, "CameraRecord");

                // Dokumentum elkésítésének sikerességének megjelenítése
                LoadingSave.fileSavedTitle.Text = "Fájl mentése sikeresen befejezödött";
                LoadingSave.fileSavedInfo.Text = "A generált fájl mostmár robotzsaruzható a 6-os főszámon";
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