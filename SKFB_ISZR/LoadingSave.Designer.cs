
namespace SKFB_ISZR
{
    partial class LoadingSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingSave));
            this.fileSavingInfo = new System.Windows.Forms.Label();
            this.fileSaving = new System.Windows.Forms.Panel();
            this.fileSaved = new System.Windows.Forms.Panel();
            this.exitSaving = new System.Windows.Forms.Button();
            this.openFileLocation = new System.Windows.Forms.Button();
            fileSavedInfo = new System.Windows.Forms.Label();
            fileSavedTitle = new System.Windows.Forms.Label();
            this.fileSaving.SuspendLayout();
            this.fileSaved.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSavingInfo
            // 
            this.fileSavingInfo.AutoSize = true;
            this.fileSavingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.fileSavingInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSavingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.fileSavingInfo.Location = new System.Drawing.Point(141, 228);
            this.fileSavingInfo.Name = "fileSavingInfo";
            this.fileSavingInfo.Size = new System.Drawing.Size(418, 45);
            this.fileSavingInfo.TabIndex = 1;
            this.fileSavingInfo.Text = "Fájl mentése folyamatban...";
            // 
            // fileSaving
            // 
            this.fileSaving.BackColor = System.Drawing.Color.Transparent;
            this.fileSaving.Controls.Add(this.fileSavingInfo);
            this.fileSaving.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.fileSaving.Location = new System.Drawing.Point(350, 150);
            this.fileSaving.Name = "fileSaving";
            this.fileSaving.Size = new System.Drawing.Size(700, 500);
            this.fileSaving.TabIndex = 2;
            // 
            // fileSaved
            // 
            this.fileSaved.BackColor = System.Drawing.Color.Transparent;
            this.fileSaved.Controls.Add(this.exitSaving);
            this.fileSaved.Controls.Add(this.openFileLocation);
            this.fileSaved.Controls.Add(fileSavedInfo);
            this.fileSaved.Controls.Add(fileSavedTitle);
            this.fileSaved.Location = new System.Drawing.Point(350, 150);
            this.fileSaved.Name = "fileSaved";
            this.fileSaved.Size = new System.Drawing.Size(700, 500);
            this.fileSaved.TabIndex = 2;
            this.fileSaved.Visible = false;
            // 
            // exitSaving
            // 
            this.exitSaving.BackColor = System.Drawing.Color.Maroon;
            this.exitSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitSaving.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.exitSaving.Location = new System.Drawing.Point(150, 329);
            this.exitSaving.Name = "exitSaving";
            this.exitSaving.Size = new System.Drawing.Size(426, 40);
            this.exitSaving.TabIndex = 32;
            this.exitSaving.Text = "Visszalépés a szolgálati jegy készítőbe";
            this.exitSaving.UseVisualStyleBackColor = false;
            this.exitSaving.Click += new System.EventHandler(this.BackToSummery);
            // 
            // openFileLocation
            // 
            this.openFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.openFileLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.openFileLocation.Location = new System.Drawing.Point(150, 283);
            this.openFileLocation.Name = "openFileLocation";
            this.openFileLocation.Size = new System.Drawing.Size(426, 40);
            this.openFileLocation.TabIndex = 32;
            this.openFileLocation.Text = "Mentett fájl helyének megnyítása";
            this.openFileLocation.UseVisualStyleBackColor = false;
            this.openFileLocation.Click += new System.EventHandler(this.OpenFileLocation);
            // 
            // fileSavedInfo
            // 
            fileSavedInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            fileSavedInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fileSavedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            fileSavedInfo.Location = new System.Drawing.Point(0, 198);
            fileSavedInfo.Name = "fileSavedInfo";
            fileSavedInfo.Size = new System.Drawing.Size(700, 45);
            fileSavedInfo.TabIndex = 1;
            fileSavedInfo.Text = "A generált fájl mostmár robotzsaruzható";
            fileSavedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSavedTitle
            // 
            fileSavedTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            fileSavedTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fileSavedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            fileSavedTitle.Location = new System.Drawing.Point(0, 153);
            fileSavedTitle.Name = "fileSavedTitle";
            fileSavedTitle.Size = new System.Drawing.Size(700, 45);
            fileSavedTitle.TabIndex = 1;
            fileSavedTitle.Text = "Fájl mentése befejezödött";
            fileSavedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            fileSavedTitle.TextChanged += new System.EventHandler(this.fileSavingFinised);
            // 
            // LoadingSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::SKFB_ISZR.Properties.Resources.theme_9_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.fileSaved);
            this.Controls.Add(this.fileSaving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingSave";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fájl mentése folyamatban...";
            this.Load += new System.EventHandler(this.LoadingSave_Load);
            this.fileSaving.ResumeLayout(false);
            this.fileSaving.PerformLayout();
            this.fileSaved.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitSaving;
        private System.Windows.Forms.Button openFileLocation;
        private System.Windows.Forms.Label fileSavingInfo;
        private System.Windows.Forms.Panel fileSaving;
        private System.Windows.Forms.Panel fileSaved;
        public static System.Windows.Forms.Label fileSavedTitle;
        public static System.Windows.Forms.Label fileSavedInfo;
    }
}