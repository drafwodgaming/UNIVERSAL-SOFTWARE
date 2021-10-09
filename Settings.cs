using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIVERSALSOFTWARE
{
    public partial class Settings : Form
    {
        public static Settings Sett;
        public Settings()
        {
            InitializeComponent();
            Sett = this;
            IconActions();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(41, 46, 68);
            Header.BackColor = Color.FromArgb(40, 45, 67);
            Panel2.BackColor = Color.FromArgb(30, 35, 57);
        }

        void IconActions()
        {
            Close.Image = Properties.Resources.CloseIcon;
            Close.Click += (s, a) => { Close(); };


            Version.ForeColor = Color.Black;
            VerNumber.ForeColor = Color.Black;
        }
        public double OpacTY { get => Opacity; set => Opacity = value; }
    }
}
