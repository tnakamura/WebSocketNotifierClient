using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WebSocketNotifierClient.Properties;

namespace WebSocketNotifierClient
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Settings.Default.IsInitialized == false)
            {
                var dialog = new SettingDialog();
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            var mainForm = new MainForm();
            mainForm.OpenClient();
            Application.Run();
        }
    }
}
