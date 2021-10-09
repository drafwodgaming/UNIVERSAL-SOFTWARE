using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIVERSALSOFTWARE
{
    public partial class MainWindow : Form
    {
        public static MainWindow Main;
        public ProgressBar DownloadBar { get => DownloadProgress; set => DownloadProgress = value; }
        public string DownloadText { get => DownloadName.Text; set => DownloadName.Text = value; }
        public double OpacTY { get => Opacity; set => Opacity = value; }
        public MainWindow()
        {
            InitializeComponent();
            Main = this;
            MainProperties.OpenProgramEffect();
            MainProperties.DragWindow();
            DownloadsIcon();
            IconActions();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(46, 51, 78);
            LeftPanel.BackColor = Color.FromArgb(40, 45, 67);
            Shadow.BackColor = Color.FromArgb(30, 35, 57);
            //DownloadProgress.BackColor = Color.Blue;
            SettingsPanel.Visible = false;
        }

        // Действия с иконками на основном окне программы - Click, MouseLeave, MouseEnter
        void IconActions()
        {
            // Иконка настроек
            Settings.Image = Properties.Resources.SettingsIcon;
            Settings.Click += (s, a) => { panel5.Hide(); SettingsPanel.Show(); }; // Запрет на повторное открытие этого окна

            // Иконка сворачивания приложения
            Minimized.Image = Properties.Resources.MinimizeIcon;
            Minimized.Click += (s, a) => { this.WindowState = FormWindowState.Minimized; };

            // Иконка закрытия приложения
            Close.Image = Properties.Resources.CloseIcon;
            Close.Click +=  (s, a) => { MainProperties.CloseProgramEffect(); };

            // Иконка скачивания (стрелочка)
            DownloadButton.Image = Properties.Resources.ArrowDownload;
            DownloadButton.MouseEnter += (s, a) => { DownloadButton.Image = Properties.Resources.ArrowDownloadActive; };
            DownloadButton.MouseLeave += (s, a) => { DownloadButton.Image = Properties.Resources.ArrowDownload; };

            // Выбор приложения (checkbox)
            SteamCheck.BackColor = Color.Transparent;
            EpicCheck.BackColor = Color.Transparent;
                        
            // Иконки выбора приложения
            SteamIcon.Image = Properties.Resources.SteamIcon;
            SteamIcon.Click += (s, a) => { if (SteamCheck.Checked == false)
                { SteamIcon.Image = Properties.Resources.SteamIconChecked; SteamIcon.Tag = "On"; SteamCheck.Checked = true; }
                else { SteamIcon.Image = Properties.Resources.SteamIcon; SteamIcon.Tag = "Off"; SteamCheck.Checked = false; } };

            EpicIcon.Image = Properties.Resources.EGIcon;
            EpicIcon.Click += (s, a) => { if (EpicCheck.Checked == false)
                { EpicIcon.Image = Properties.Resources.EGIconChecked; EpicIcon.Tag = "On"; EpicCheck.Checked = true; }
                else { EpicIcon.Image = Properties.Resources.EGIcon; EpicIcon.Tag = "Off"; EpicCheck.Checked = false; } };

            // Текст мониторинга скачивания
            DownloadName.ForeColor = Color.SkyBlue;
            DownloadProgress.ForeColor = Color.FromArgb(60, 65, 88);

            OpenFolder.Click += (s, a) => { OpenDownloadFolder(DownloadsLaunchers.DownloadPath); };
        }
        void DownloadsIcon()
        {
            DownloadButton.Click += (s, e) =>
            {
                Parallel.Invoke(
                    () =>
                    {
                        //Задача 1
                        if (SteamCheck.Checked == true) { new Thread(() => { Invoke((MethodInvoker)(() => { DownloadsLaunchers.SteamDownload(); })); }).Start(); }
                    },
                    () =>
                    {
                        // Задача 2
                        if (EpicCheck.Checked == true) { new Thread(() => { Invoke((MethodInvoker)(() => { DownloadsLaunchers.EpicDownload(); })); }).Start(); }
                    });
            };
        }
        void OpenDownloadFolder(string line)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n, {line}" });
        }
    }
}
