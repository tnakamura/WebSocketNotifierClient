using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebSocketNotifierClient.Properties;

namespace WebSocketNotifierClient
{
    public partial class SettingDialog : Form
    {
        public SettingDialog()
        {
            InitializeComponent();
        }

        private void SettingDialog_Load(object sender, EventArgs e)
        {
            _urlTextBox.Text = Settings.Default.Url;
            _timeoutNumericUpDown.Value = Math.Min(30, Settings.Default.BalloonTipTimeout);
            _errorOnlyCheckBox.Checked = Settings.Default.ShowErrorOnly;
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _onButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Url = _urlTextBox.Text;
            Settings.Default.ShowErrorOnly = _errorOnlyCheckBox.Checked;
            Settings.Default.BalloonTipTimeout = _timeoutNumericUpDown.Value;
            Settings.Default.IsInitialized = true;
            Settings.Default.Save();
            Close();
        }
    }
}
