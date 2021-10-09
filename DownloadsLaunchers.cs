using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIVERSALSOFTWARE
{
    public static class DownloadsLaunchers
    {
        static string FilePath;
        public static string DownloadPath = KnownFolders.GetPath(KnownFolder.Downloads); // Путь папки загрузки

        // Скачивание программы
        public static void SteamDownload()
        {
            FilePath = $@"{DownloadPath}\SteamSetup.exe"; // Путь сохранения файла

            // Раньше при скачке, пока файл не скачался, программа звисала. DownloadFileAsync - исправляет это.
            using (WebClient Wc = new WebClient())
            {
                Wc.DownloadProgressChanged += (s, a) => { MainWindow.Main.DownloadText = $"STEAM: {a.ProgressPercentage}% " +
                    $"({((double)a.BytesReceived / 1048576).ToString("#.#")} МБ / " +
                    $"{((double)a.TotalBytesToReceive / 1048576).ToString("#.#")} МБ)"; 
                    MainWindow.Main.DownloadBar.Value = a.ProgressPercentage; }; // Загрузка показывается в прогрессбаре
                Wc.DownloadFileAsync(new Uri("https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe"), FilePath);
                Wc.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted);
            }
        }

        public static void EpicDownload()
        {
            FilePath = $@"{DownloadPath}\Epic-Installer.msi";
            // Раньше при скачке, пока файл не скачался, программа звисала. DownloadFileAsync - исправляет это.
            using (WebClient Wc = new WebClient())
            {
                Wc.DownloadProgressChanged += (s, a) => { MainWindow.Main.DownloadText = $"EPIC LAUNCHER: {a.ProgressPercentage}% " +
                    $"({((double)a.BytesReceived / 1048576).ToString("#.#")} МБ / " +
                    $"{((double)a.TotalBytesToReceive/ 1048576).ToString("#.#")} МБ)"; 
                    MainWindow.Main.DownloadBar.Value = a.ProgressPercentage; }; // Загрузка показывается в прогрессбаре
                Wc.DownloadFileAsync(new Uri("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi"), FilePath);
            }
        }

        static void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null) { }
        }
    }
}
