using SKFB_ISZR.Tools;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class LoadingSplashScreen : Form
    {
        // Felhasználó teljes neve
        public static string userFullName; 

        // Felhasználó mappájának útvonala
        public static string userProfilePath;

        // Dokumentum mentéshez időpont
        public static string dayToday = DateTime.Now.ToString("yyyy.MM.dd");

        // Kamera lementéseshez mint minimum dátum (max felvételi idő)
        public static DateTime minRecordDay = DateTime.Now.AddDays(-32);

        // Kamera lementéshez mai dátum mint maximum
        public static DateTime maxRecordDay = DateTime.Now;

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

        public LoadingSplashScreen()
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Userprofile útvonat lekérdezése
            userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            userProfilePath += "\\ISZR\\";
        }

        // Felület betöltése
        private void LoadingScreen_Load(object sender, EventArgs e) => GC.Collect();

        // Felület megjelenése
        private void LoadingSplashScreen_Shown(object sender, EventArgs e)
        {
            // Felhasználó nevének lekérdezése
            userFullName = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
            DocumentEditor.fullName = userFullName;

            // Alapértelmezett dokumentum átmásolása a felhasználó gyökérkönyvtárába (megvan nyítva a fájl elleni megoldás)
            CopyModelFolderToProfilePath();

            // Timer elindítása
            loadingTimer.Enabled = true;
        }

        // Splash megjelenítésének kikapcsolása, átlépés a Dashboardra
        private void Timer_Tick(object sender, EventArgs e)
        {
            loadingTimer.Enabled = false;
            MainDashboard mainDashboard = new MainDashboard();
            this.Hide();
            mainDashboard.Show();
        }

        // Modellek mappa tartalmának átmásolása a felhasználó profiljának mappájába
        private static void CopyModelFolderToProfilePath()
        {
            // Modellek mappa útvonala
            DirectoryInfo dir = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}Models\\");

            // Felhasználó profil mappájának elkészítése ha még nem létezik
            Directory.CreateDirectory(userProfilePath);

            // Modells átmásolása a felhasználó profiljának mappájába
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(userProfilePath, file.Name);
                file.CopyTo(tempPath, true);
            }
        }
    }
}