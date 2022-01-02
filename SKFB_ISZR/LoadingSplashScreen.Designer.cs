
namespace SKFB_ISZR
{
    partial class LoadingSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingSplashScreen));
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 1000;
            this.loadingTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LoadingSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.BackgroundImage = global::SKFB_ISZR.Properties.Resources.loadingScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 390);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.Shown += new System.EventHandler(this.LoadingSplashScreen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer loadingTimer;
    }
}