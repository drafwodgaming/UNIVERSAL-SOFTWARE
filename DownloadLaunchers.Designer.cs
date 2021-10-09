
namespace LNDOWNLOADER
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Close);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(537, 34);
            this.Panel1.TabIndex = 8;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(492, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 32);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(0, 32);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(537, 4);
            this.Panel2.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 351);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private new System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel Panel2;
    }
}