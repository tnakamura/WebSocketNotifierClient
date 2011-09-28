using System;
using System.Threading;
using System.Windows.Forms;
using WebSocketNotifierClient.Properties;
using WebSocketSharp;

namespace WebSocketNotifierClient
{
    public partial class MainForm : Form
    {
        private WebSocket _client;

        public MainForm()
        {
            InitializeComponent();

            _notifyIcon.Text = Text;
            _notifyIcon.Icon = Resources.announcements;
            Application.ThreadException += OnThreadException;
            Application.ApplicationExit += OnApplicationExit;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (_client != null)
            {
                _client.Close();
                _client = null;
            }
        }

        private void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowBalloon(ToolTipIcon.Error, e.Exception.Message);
        }

        private void OnError(object sender, string message)
        {
            ShowBalloon(ToolTipIcon.Error, message);
        }

        private void OnRecievedMessage(object sender, string message)
        {
            var result = BuildResult.Parse(message);
            var msg = result.ToMessage();

            // ポップアップを表示
            if (result.IsSuccess)
            {
                if (Settings.Default.ShowErrorOnly == false)
                {
                    ShowBalloon(ToolTipIcon.Info, msg);
                }
            }
            else if (result.IsUnstable)
            {
                if (Settings.Default.ShowErrorOnly == false)
                {
                    ShowBalloon(ToolTipIcon.Warning, msg);
                }
            }
            else
            {
                ShowBalloon(ToolTipIcon.Error, msg);
            }
        }

        private void ShowBalloon(ToolTipIcon icon, string message)
        {
            _notifyIcon.BalloonTipIcon = icon;
            _notifyIcon.BalloonTipTitle = Resources.WebSocketServerName;
            _notifyIcon.BalloonTipText = message;
            _notifyIcon.ShowBalloonTip((int)(Settings.Default.BalloonTipTimeout * 1000));
        }

        public void OpenClient()
        {
            if (_client != null)
            {
                _client.OnMessage -= OnRecievedMessage;
                _client.OnError -= OnError; 
                _client.Close();
            }
            _client = new WebSocket(Settings.Default.Url);
            _client.OnMessage += OnRecievedMessage;
            _client.OnError += OnError;
            _client.Connect();
        }

        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SettingDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                OpenClient();
            }
        }
    }
}
