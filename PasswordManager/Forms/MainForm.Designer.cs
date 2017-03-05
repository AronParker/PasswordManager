namespace PasswordManager.Forms
{
    partial class MainForm
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
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._passphraseLabel = new System.Windows.Forms.Label();
            this._passphraseTextBox = new System.Windows.Forms.TextBox();
            this._tagLabel = new System.Windows.Forms.Label();
            this._tagTextBox = new System.Windows.Forms.TextBox();
            this._lengthLabel = new System.Windows.Forms.Label();
            this._lengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._copyButton = new System.Windows.Forms.Button();
            this._characterSetLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._showPassphraseCheckBox = new System.Windows.Forms.CheckBox();
            this._characterSetComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._lengthNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _passphraseLabel
            // 
            this._passphraseLabel.Location = new System.Drawing.Point(12, 12);
            this._passphraseLabel.Name = "_passphraseLabel";
            this._passphraseLabel.Size = new System.Drawing.Size(80, 23);
            this._passphraseLabel.TabIndex = 0;
            this._passphraseLabel.Text = "Passphrase:";
            this._passphraseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _passphraseTextBox
            // 
            this._passphraseTextBox.Location = new System.Drawing.Point(98, 12);
            this._passphraseTextBox.Name = "_passphraseTextBox";
            this._passphraseTextBox.Size = new System.Drawing.Size(250, 23);
            this._passphraseTextBox.TabIndex = 1;
            this._passphraseTextBox.UseSystemPasswordChar = true;
            // 
            // _tagLabel
            // 
            this._tagLabel.Location = new System.Drawing.Point(354, 12);
            this._tagLabel.Name = "_tagLabel";
            this._tagLabel.Size = new System.Drawing.Size(30, 23);
            this._tagLabel.TabIndex = 2;
            this._tagLabel.Text = "Tag:";
            this._tagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tagTextBox
            // 
            this._tagTextBox.Location = new System.Drawing.Point(390, 12);
            this._tagTextBox.Name = "_tagTextBox";
            this._tagTextBox.Size = new System.Drawing.Size(150, 23);
            this._tagTextBox.TabIndex = 3;
            // 
            // _lengthLabel
            // 
            this._lengthLabel.Location = new System.Drawing.Point(354, 41);
            this._lengthLabel.Name = "_lengthLabel";
            this._lengthLabel.Size = new System.Drawing.Size(100, 23);
            this._lengthLabel.TabIndex = 6;
            this._lengthLabel.Text = "Password length:";
            this._lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lengthNumericUpDown
            // 
            this._lengthNumericUpDown.Location = new System.Drawing.Point(460, 41);
            this._lengthNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this._lengthNumericUpDown.Name = "_lengthNumericUpDown";
            this._lengthNumericUpDown.Size = new System.Drawing.Size(80, 23);
            this._lengthNumericUpDown.TabIndex = 7;
            this._lengthNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // _copyButton
            // 
            this._copyButton.Image = global::PasswordManager.Properties.Resources.key;
            this._copyButton.Location = new System.Drawing.Point(390, 12);
            this._copyButton.Name = "_copyButton";
            this._copyButton.Size = new System.Drawing.Size(150, 26);
            this._copyButton.TabIndex = 0;
            this._copyButton.Text = "Copy password";
            this._copyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._copyButton.UseVisualStyleBackColor = true;
            this._copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // _characterSetLabel
            // 
            this._characterSetLabel.Location = new System.Drawing.Point(12, 41);
            this._characterSetLabel.Name = "_characterSetLabel";
            this._characterSetLabel.Size = new System.Drawing.Size(80, 23);
            this._characterSetLabel.TabIndex = 4;
            this._characterSetLabel.Text = "Character set:";
            this._characterSetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this._showPassphraseCheckBox);
            this.panel1.Controls.Add(this._copyButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 50);
            this.panel1.TabIndex = 8;
            // 
            // _showPassphraseCheckBox
            // 
            this._showPassphraseCheckBox.Location = new System.Drawing.Point(12, 12);
            this._showPassphraseCheckBox.Name = "_showPassphraseCheckBox";
            this._showPassphraseCheckBox.Size = new System.Drawing.Size(230, 26);
            this._showPassphraseCheckBox.TabIndex = 1;
            this._showPassphraseCheckBox.Text = "Show passphrase";
            this._showPassphraseCheckBox.UseVisualStyleBackColor = true;
            this._showPassphraseCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassphraseCheckBox_CheckedChanged);
            // 
            // _characterSetComboBox
            // 
            this._characterSetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._characterSetComboBox.FormattingEnabled = true;
            this._characterSetComboBox.Location = new System.Drawing.Point(98, 41);
            this._characterSetComboBox.Name = "_characterSetComboBox";
            this._characterSetComboBox.Size = new System.Drawing.Size(250, 23);
            this._characterSetComboBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AcceptButton = this._copyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 126);
            this.Controls.Add(this._characterSetComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lengthNumericUpDown);
            this.Controls.Add(this._lengthLabel);
            this.Controls.Add(this._characterSetLabel);
            this.Controls.Add(this._tagTextBox);
            this.Controls.Add(this._tagLabel);
            this.Controls.Add(this._passphraseTextBox);
            this.Controls.Add(this._passphraseLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Password manager";
            ((System.ComponentModel.ISupportInitialize)(this._lengthNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _passphraseLabel;
        private System.Windows.Forms.TextBox _passphraseTextBox;
        private System.Windows.Forms.Label _tagLabel;
        private System.Windows.Forms.TextBox _tagTextBox;
        private System.Windows.Forms.Label _lengthLabel;
        private System.Windows.Forms.NumericUpDown _lengthNumericUpDown;
        private System.Windows.Forms.Button _copyButton;
        private System.Windows.Forms.Label _characterSetLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox _showPassphraseCheckBox;
        private System.Windows.Forms.ComboBox _characterSetComboBox;
    }
}

