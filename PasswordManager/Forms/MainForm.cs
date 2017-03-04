using System;
using System.Windows.Forms;
using PasswordManager.Security;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler ChangeCharacterSet
        {
            add => _characterSetButton.Click += value;
            remove => _characterSetButton.Click -= value;
        }

        public event EventHandler CopyPasswordRequested
        {
            add => _copyButton.Click += value;
            remove => _copyButton.Click -= value;
        }

        public string Passphrase
        {
            get => _passphraseTextBox.Text;
            set => _passphraseTextBox.Text = value;
        }

        public string PassphraseTag
        {
            get => _tagTextBox.Text;
            set => _tagTextBox.Text = value;
        }

        public string CharacterSet
        {
            get => _characterSetTextBox.Text;
            set => _characterSetTextBox.Text = value;
        }

        public int Length
        {
            get => (int)_lengthNumericUpDown.Value;
            set => _lengthNumericUpDown.Value = value;
        }

        public bool ShowPassphrase
        {
            get => _showPassphraseCheckBox.Checked;
            set => _showPassphraseCheckBox.Checked = value;
        }

        private void ShowPassphraseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _passphraseTextBox.UseSystemPasswordChar = !_showPassphraseCheckBox.Checked;
        }
        /*
        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (_passphraseChanged)
            {
                _passwordBuilder.Passphrase = _passphraseTextBox.Text;
                _passphraseChanged = false;
            }

            var characterSet = GetCharacterSet();

            if (characterSet == null)
            {
                MessageBox.Show("You must check at least one set of characters.", "No character sets checked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var password = _passwordBuilder.GetPassword(_tagTextBox.Text, characterSet, (int)_lengthNumericUpDown.Value);
            
            Clipboard.SetText(password);
        }*/
    }
}
