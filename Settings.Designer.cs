
namespace UNIVERSALSOFTWARE
{
    partial class Settings
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
            this.Header = new System.Windows.Forms.Panel();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.VerNumber = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(636, 34);
            this.Header.TabIndex = 8;
            // 
            // OpenFolder
            // 
            this.OpenFolder.FlatAppearance.BorderSize = 0;
            this.OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolder.Location = new System.Drawing.Point(152, 114);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(148, 23);
            this.OpenFolder.TabIndex = 5;
            this.OpenFolder.Text = "Открыть папку загрузки";
            this.OpenFolder.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(549, 114);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 20);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(0, 32);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(636, 4);
            this.Panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(232, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Проверить обновления";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Close);
            this.panel6.Controls.Add(this.OpenFolder);
            this.panel6.Controls.Add(this.VerNumber);
            this.panel6.Controls.Add(this.Version);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(636, 324);
            this.panel6.TabIndex = 14;
            // 
            // VerNumber
            // 
            this.VerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerNumber.ForeColor = System.Drawing.Color.Black;
            this.VerNumber.Location = new System.Drawing.Point(88, 17);
            this.VerNumber.Name = "VerNumber";
            this.VerNumber.Size = new System.Drawing.Size(89, 23);
            this.VerNumber.TabIndex = 3;
            this.VerNumber.Text = "0.12 alpha";
            // 
            // Version
            // 
            this.Version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Version.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.Black;
            this.Version.Location = new System.Drawing.Point(25, 17);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(71, 23);
            this.Version.TabIndex = 2;
            this.Version.Text = "Версия:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 358);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Header);
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Header;
        private new System.Windows.Forms.PictureBox Close;
        public System.Windows.Forms.Panel Panel2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label VerNumber;
        private System.Windows.Forms.Button OpenFolder;
    }
}