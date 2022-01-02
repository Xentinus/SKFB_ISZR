using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    public partial class LoadingSave : Form
    {
        // Mentett fájl elérési útvonala
        public static string savedFileLocation = " ";

        // Szűlő ablak
        private Form parentForm;

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

        public LoadingSave(Form ParentForm)
        {
            InitializeComponent();

            // Lekerekített sarok megjelenítése
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Szűlő ablakának eltüntetése és elmentése
            parentForm = ParentForm;
            parentForm.Hide();
            Show();
        }

        // Felület betöltése
        private void LoadingSave_Load(object sender, EventArgs e) => GC.Collect();

        // Fájl helyének megnyítása
        private void OpenFileLocation(object sender, EventArgs e) => System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", savedFileLocation));

        // Fájl mentés felületének bezárása
        private void BackToSummery(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            parentForm.Close();
            Dispose();
        }

        private void fileSavingFinised(object sender, EventArgs e)
        {
            fileSaving.Visible = false;
            fileSaved.Visible = Enabled;
        }
    }
}