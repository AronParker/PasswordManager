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
            if (disposing)
            {
                if (components != null)
                    components.Dispose();

                _passwordBuilder.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._passphraseLabel = new System.Windows.Forms.Label();
            this._passphraseTextBox = new System.Windows.Forms.TextBox();
            this._tagLabel = new System.Windows.Forms.Label();
            this._tagTextBox = new System.Windows.Forms.TextBox();
            this._lengthLabel = new System.Windows.Forms.Label();
            this._lengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._copyButton = new System.Windows.Forms.Button();
            this._lowercaseLettersCheckBox = new System.Windows.Forms.CheckBox();
            this._uppercaseLettersCheckBox = new System.Windows.Forms.CheckBox();
            this._numbersCheckBox = new System.Windows.Forms.CheckBox();
            this._symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this._showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this._showTagCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._lengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _passphraseLabel
            // 
            this._passphraseLabel.Location = new System.Drawing.Point(12, 12);
            this._passphraseLabel.Name = "_passphraseLabel";
            this._passphraseLabel.Size = new System.Drawing.Size(100, 23);
            this._passphraseLabel.TabIndex = 0;
            this._passphraseLabel.Text = "Passphrase:";
            this._passphraseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _passphraseTextBox
            // 
            this._passphraseTextBox.Location = new System.Drawing.Point(118, 12);
            this._passphraseTextBox.Name = "_passphraseTextBox";
            this._passphraseTextBox.Size = new System.Drawing.Size(300, 23);
            this._passphraseTextBox.TabIndex = 1;
            this._passphraseTextBox.UseSystemPasswordChar = true;
            this._passphraseTextBox.TextChanged += new System.EventHandler(this.PassphraseTextBox_TextChanged);
            // 
            // _tagLabel
            // 
            this._tagLabel.Location = new System.Drawing.Point(12, 41);
            this._tagLabel.Name = "_tagLabel";
            this._tagLabel.Size = new System.Drawing.Size(100, 23);
            this._tagLabel.TabIndex = 2;
            this._tagLabel.Text = "Tag:";
            this._tagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tagTextBox
            // 
            this._tagTextBox.Location = new System.Drawing.Point(118, 41);
            this._tagTextBox.Name = "_tagTextBox";
            this._tagTextBox.Size = new System.Drawing.Size(300, 23);
            this._tagTextBox.TabIndex = 3;
            // 
            // _lengthLabel
            // 
            this._lengthLabel.Location = new System.Drawing.Point(12, 70);
            this._lengthLabel.Name = "_lengthLabel";
            this._lengthLabel.Size = new System.Drawing.Size(100, 23);
            this._lengthLabel.TabIndex = 8;
            this._lengthLabel.Text = "Password length:";
            this._lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lengthNumericUpDown
            // 
            this._lengthNumericUpDown.Location = new System.Drawing.Point(118, 70);
            this._lengthNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this._lengthNumericUpDown.Name = "_lengthNumericUpDown";
            this._lengthNumericUpDown.Size = new System.Drawing.Size(45, 23);
            this._lengthNumericUpDown.TabIndex = 9;
            this._lengthNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // _copyButton
            // 
            this._copyButton.Location = new System.Drawing.Point(386, 70);
            this._copyButton.Name = "_copyButton";
            this._copyButton.Size = new System.Drawing.Size(155, 51);
            this._copyButton.TabIndex = 11;
            this._copyButton.Text = "Copy password to clipboard";
            this._copyButton.UseVisualStyleBackColor = true;
            this._copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // _lowercaseLettersCheckBox
            // 
            this._lowercaseLettersCheckBox.Checked = true;
            this._lowercaseLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._lowercaseLettersCheckBox.Location = new System.Drawing.Point(169, 70);
            this._lowercaseLettersCheckBox.Name = "_lowercaseLettersCheckBox";
            this._lowercaseLettersCheckBox.Size = new System.Drawing.Size(125, 23);
            this._lowercaseLettersCheckBox.TabIndex = 4;
            this._lowercaseLettersCheckBox.Text = "Lowercase letters";
            this._lowercaseLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // _uppercaseLettersCheckBox
            // 
            this._uppercaseLettersCheckBox.Checked = true;
            this._uppercaseLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._uppercaseLettersCheckBox.Location = new System.Drawing.Point(169, 99);
            this._uppercaseLettersCheckBox.Name = "_uppercaseLettersCheckBox";
            this._uppercaseLettersCheckBox.Size = new System.Drawing.Size(125, 23);
            this._uppercaseLettersCheckBox.TabIndex = 5;
            this._uppercaseLettersCheckBox.Text = "Uppercase letters";
            this._uppercaseLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // _numbersCheckBox
            // 
            this._numbersCheckBox.Checked = true;
            this._numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._numbersCheckBox.Location = new System.Drawing.Point(300, 70);
            this._numbersCheckBox.Name = "_numbersCheckBox";
            this._numbersCheckBox.Size = new System.Drawing.Size(80, 23);
            this._numbersCheckBox.TabIndex = 6;
            this._numbersCheckBox.Text = "Numbers";
            this._numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // _symbolsCheckBox
            // 
            this._symbolsCheckBox.Checked = true;
            this._symbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._symbolsCheckBox.Location = new System.Drawing.Point(300, 99);
            this._symbolsCheckBox.Name = "_symbolsCheckBox";
            this._symbolsCheckBox.Size = new System.Drawing.Size(80, 23);
            this._symbolsCheckBox.TabIndex = 7;
            this._symbolsCheckBox.Text = "Symbols";
            this._symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // _showPasswordCheckBox
            // 
            this._showPasswordCheckBox.Location = new System.Drawing.Point(424, 13);
            this._showPasswordCheckBox.Name = "_showPasswordCheckBox";
            this._showPasswordCheckBox.Size = new System.Drawing.Size(120, 23);
            this._showPasswordCheckBox.TabIndex = 10;
            this._showPasswordCheckBox.Text = "Show passphrase";
            this._showPasswordCheckBox.UseVisualStyleBackColor = true;
            this._showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // _showTagCheckBox
            // 
            this._showTagCheckBox.Checked = true;
            this._showTagCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._showTagCheckBox.Location = new System.Drawing.Point(424, 42);
            this._showTagCheckBox.Name = "_showTagCheckBox";
            this._showTagCheckBox.Size = new System.Drawing.Size(120, 23);
            this._showTagCheckBox.TabIndex = 12;
            this._showTagCheckBox.Text = "Show tag";
            this._showTagCheckBox.UseVisualStyleBackColor = true;
            this._showTagCheckBox.CheckedChanged += new System.EventHandler(this.ShowTagCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this._copyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(553, 133);
            this.Controls.Add(this._showTagCheckBox);
            this.Controls.Add(this._showPasswordCheckBox);
            this.Controls.Add(this._copyButton);
            this.Controls.Add(this._symbolsCheckBox);
            this.Controls.Add(this._numbersCheckBox);
            this.Controls.Add(this._uppercaseLettersCheckBox);
            this.Controls.Add(this._lowercaseLettersCheckBox);
            this.Controls.Add(this._lengthNumericUpDown);
            this.Controls.Add(this._lengthLabel);
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
        private System.Windows.Forms.CheckBox _lowercaseLettersCheckBox;
        private System.Windows.Forms.CheckBox _uppercaseLettersCheckBox;
        private System.Windows.Forms.CheckBox _numbersCheckBox;
        private System.Windows.Forms.CheckBox _symbolsCheckBox;
        private System.Windows.Forms.CheckBox _showPasswordCheckBox;
        private System.Windows.Forms.CheckBox _showTagCheckBox;
    }
}

