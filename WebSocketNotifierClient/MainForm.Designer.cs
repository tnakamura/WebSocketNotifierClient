namespace WebSocketNotifierClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _notifyIcon
            // 
            this._notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._notifyIcon.ContextMenuStrip = this._contextMenuStrip;
            this._notifyIcon.Text = "notifyIcon1";
            this._notifyIcon.Visible = true;
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._settingsToolStripMenuItem,
            this._exitToolStripMenuItem});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(227, 48);
            // 
            // _settingsToolStripMenuItem
            // 
            this._settingsToolStripMenuItem.Name = "_settingsToolStripMenuItem";
            this._settingsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this._settingsToolStripMenuItem.Text = "設定(&S)";
            this._settingsToolStripMenuItem.Click += new System.EventHandler(this._settingsToolStripMenuItem_Click);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this._exitToolStripMenuItem.Text = "アプリケーションの終了(&X)";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this._exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "WebSocketNotifierClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
    }
}

