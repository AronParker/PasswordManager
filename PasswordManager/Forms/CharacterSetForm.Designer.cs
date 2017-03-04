namespace PasswordManager.Forms
{
    partial class CharacterSetForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._lowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this._uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this._numbersCheckBox = new System.Windows.Forms.CheckBox();
            this._spaceCheckBox = new System.Windows.Forms.CheckBox();
            this._symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this._cancelButton);
            this.panel1.Controls.Add(this._okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 50);
            this.panel1.TabIndex = 13;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(118, 12);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(100, 26);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(12, 12);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(100, 26);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _lowercaseCheckBox
            // 
            this._lowercaseCheckBox.Location = new System.Drawing.Point(12, 12);
            this._lowercaseCheckBox.Name = "_lowercaseCheckBox";
            this._lowercaseCheckBox.Size = new System.Drawing.Size(206, 23);
            this._lowercaseCheckBox.TabIndex = 1;
            this._lowercaseCheckBox.Text = "Lowercase characters";
            this._lowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // _uppercaseCheckBox
            // 
            this._uppercaseCheckBox.Location = new System.Drawing.Point(12, 41);
            this._uppercaseCheckBox.Name = "_uppercaseCheckBox";
            this._uppercaseCheckBox.Size = new System.Drawing.Size(206, 23);
            this._uppercaseCheckBox.TabIndex = 1;
            this._uppercaseCheckBox.Text = "Uppercase characters";
            this._uppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // _numbersCheckBox
            // 
            this._numbersCheckBox.Location = new System.Drawing.Point(12, 70);
            this._numbersCheckBox.Name = "_numbersCheckBox";
            this._numbersCheckBox.Size = new System.Drawing.Size(206, 23);
            this._numbersCheckBox.TabIndex = 1;
            this._numbersCheckBox.Text = "Numbers";
            this._numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // _spaceCheckBox
            // 
            this._spaceCheckBox.Location = new System.Drawing.Point(12, 99);
            this._spaceCheckBox.Name = "_spaceCheckBox";
            this._spaceCheckBox.Size = new System.Drawing.Size(206, 23);
            this._spaceCheckBox.TabIndex = 1;
            this._spaceCheckBox.Text = "Spaces";
            this._spaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // _symbolsCheckBox
            // 
            this._symbolsCheckBox.Location = new System.Drawing.Point(12, 128);
            this._symbolsCheckBox.Name = "_symbolsCheckBox";
            this._symbolsCheckBox.Size = new System.Drawing.Size(206, 23);
            this._symbolsCheckBox.TabIndex = 1;
            this._symbolsCheckBox.Text = "Symbols";
            this._symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CharacterSetForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(230, 207);
            this.Controls.Add(this._symbolsCheckBox);
            this.Controls.Add(this._spaceCheckBox);
            this.Controls.Add(this._numbersCheckBox);
            this.Controls.Add(this._uppercaseCheckBox);
            this.Controls.Add(this._lowercaseCheckBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Choose character sets";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.CheckBox _lowercaseCheckBox;
        private System.Windows.Forms.CheckBox _uppercaseCheckBox;
        private System.Windows.Forms.CheckBox _numbersCheckBox;
        private System.Windows.Forms.CheckBox _spaceCheckBox;
        private System.Windows.Forms.CheckBox _symbolsCheckBox;
    }
}