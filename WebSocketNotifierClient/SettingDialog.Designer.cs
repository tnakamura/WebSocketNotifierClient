namespace WebSocketNotifierClient
{
    partial class SettingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingDialog));
            this.label1 = new System.Windows.Forms.Label();
            this._urlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._timeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._errorOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this._onButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._timeoutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "WebSocket サーバーの URL:";
            // 
            // _urlTextBox
            // 
            this._urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._urlTextBox.Location = new System.Drawing.Point(14, 25);
            this._urlTextBox.Name = "_urlTextBox";
            this._urlTextBox.Size = new System.Drawing.Size(318, 19);
            this._urlTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "表示時間(秒)";
            // 
            // _timeoutNumericUpDown
            // 
            this._timeoutNumericUpDown.Location = new System.Drawing.Point(16, 67);
            this._timeoutNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._timeoutNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._timeoutNumericUpDown.Name = "_timeoutNumericUpDown";
            this._timeoutNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this._timeoutNumericUpDown.TabIndex = 3;
            this._timeoutNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._timeoutNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // _errorOnlyCheckBox
            // 
            this._errorOnlyCheckBox.AutoSize = true;
            this._errorOnlyCheckBox.Location = new System.Drawing.Point(142, 68);
            this._errorOnlyCheckBox.Name = "_errorOnlyCheckBox";
            this._errorOnlyCheckBox.Size = new System.Drawing.Size(151, 16);
            this._errorOnlyCheckBox.TabIndex = 4;
            this._errorOnlyCheckBox.Text = "ビルド失敗時のみ通知する";
            this._errorOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // _onButton
            // 
            this._onButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._onButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._onButton.Location = new System.Drawing.Point(176, 100);
            this._onButton.Name = "_onButton";
            this._onButton.Size = new System.Drawing.Size(75, 23);
            this._onButton.TabIndex = 5;
            this._onButton.Text = "OK";
            this._onButton.UseVisualStyleBackColor = true;
            this._onButton.Click += new System.EventHandler(this._onButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(257, 100);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 6;
            this._cancelButton.Text = "キャンセル";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 135);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._onButton);
            this.Controls.Add(this._errorOnlyCheckBox);
            this.Controls.Add(this._timeoutNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._urlTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebSocketNotifierClient の設定";
            this.Load += new System.EventHandler(this.SettingDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this._timeoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _urlTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _timeoutNumericUpDown;
        private System.Windows.Forms.CheckBox _errorOnlyCheckBox;
        private System.Windows.Forms.Button _onButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}