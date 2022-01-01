
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
            this.version = new System.Windows.Forms.Label();
            this.versionDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 3000;
            this.loadingTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.version.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.version.Location = new System.Drawing.Point(10, 330);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(123, 25);
            this.version.TabIndex = 12;
            this.version.Text = "Verzió 1.2.1.0";
            this.version.UseWaitCursor = true;
            // 
            // versionDate
            // 
            this.versionDate.AutoSize = true;
            this.versionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.versionDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.versionDate.Location = new System.Drawing.Point(10, 355);
            this.versionDate.Name = "versionDate";
            this.versionDate.Size = new System.Drawing.Size(88, 21);
            this.versionDate.TabIndex = 11;
            this.versionDate.Text = "2022.01.01";
            this.versionDate.UseWaitCursor = true;
            // 
            // LoadingSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.BackgroundImage = global::SKFB_ISZR.Properties.Resources.loadingScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 390);
            this.Controls.Add(this.versionDate);
            this.Controls.Add(this.version);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label versionDate;
    }
}