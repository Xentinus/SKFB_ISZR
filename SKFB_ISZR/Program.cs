using System;
using System.IO;
using System.Windows.Forms;

namespace SKFB_ISZR
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingSplashScreen());
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(LoadingSplashScreen.userProfilePath);

            try
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch
            {
            }
        }
    }
}