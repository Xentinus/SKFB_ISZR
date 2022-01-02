using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class MainDashboard : Form
    {
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

        public MainDashboard()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Felhasználó üdvözlése a nevén
            welcomeText.Text += $"{LoadingSplashScreen.userFullName}!";

            // Szabad NTG számok megszámolása, és gomb beállítása
            CheckSetNTG_Button();
        }

        // Felület betöltése
        private void Dashboard_Load(object sender, EventArgs e) => GC.Collect();

        // Program teljes bezárása
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        // Program tálcára tétele
        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        // Programmal kapcsolatos segítségek mappa megnyítása
        private void HelpdeskButton_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("explorer.exe", "\\\\skfb-file01\\Org\\Informatika\\Publikus\\ISZR");

        // Parkolási kártyát igénylő folyamat megnyítása
        private void RequestParkingCardButton_Click(object sender, EventArgs e)
        {
            RequestParkingCard parking = new RequestParkingCard();
            parking.Show();
            Dispose();
        }

        // Email címet igénylő folyamat megnyítása
        private void RequestEmailAdressButton_Click(object sender, EventArgs e)
        {
            RequestEmail email = new RequestEmail();
            email.Show();
            Dispose();
        }

        // Főnix3 hozzáféréseket igénylő folyamat megnyítása
        private void FonixPermissionsButton_Click(object sender, EventArgs e)
        {
            FonixPermissions fonix3 = new FonixPermissions();
            fonix3.Show();
            Dispose();
        }

        // Windows hozzáféréseket igénylő folyamat megnyítása
        private void WindowsPermissionsButton_Click(object sender, EventArgs e)
        {
            WindowsPermissions windows = new WindowsPermissions();
            windows.Show();
            Dispose();
        }

        // Telefon PIN-t igénylő folyamat megnyítása
        private void RequestPhonePINButton_Click(object sender, EventArgs e)
        {
            RequestPhonePIN telefonpin = new RequestPhonePIN();
            telefonpin.Show();
            Dispose(); ;
        }

        // Kamera rendszer jogosultságot igénylő folyamat megnyítása
        private void CameraPermissionsButton_Click(object sender, EventArgs e)
        {
            CameraPermissions kameraJogosultsag = new CameraPermissions();
            kameraJogosultsag.Show();
            Dispose();
        }

        // Kameraképet lementéséhez szükséges folyamat megnyítása
        private void CameraRecordButton_Click(object sender, EventArgs e)
        {
            CameraRecord kameraKep = new CameraRecord();
            kameraKep.Show();
            Dispose();
        }
        private void CheckSetNTG_Button()
        {
            var lineCount = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "Database\\AvailablePINs.txt").Count();
            phoneButton.Enabled = lineCount > 1;
            noPINAlertBox.Visible = !phoneButton.Enabled;
            noPINAlertText.Visible = !phoneButton.Enabled;
        }
    }
}