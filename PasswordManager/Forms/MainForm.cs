using System;
using System.Windows.Forms;
using PasswordManager.Security;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        private PasswordBuilder _passwordBuilder;
        private bool _passphraseChanged;

        public MainForm()
        {
            InitializeComponent();

            _passwordBuilder = new PasswordBuilder();
        }

        private void PassphraseTextBox_TextChanged(object sender, EventArgs e)
        {
            _passphraseChanged = true;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _passphraseTextBox.UseSystemPasswordChar = !_showPasswordCheckBox.Checked;
        }

        private void ShowTagCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tagTextBox.UseSystemPasswordChar = !_showTagCheckBox.Checked;
        }

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
        }

        private string GetCharacterSet()
        {
            CharacterGroups groups = 0;

            if (_lowercaseLettersCheckBox.Checked)
                groups |= CharacterGroups.LowercaseLetters;

            if (_uppercaseLettersCheckBox.Checked)
                groups |= CharacterGroups.UppercaseLetters;

            if (_numbersCheckBox.Checked)
                groups |= CharacterGroups.Numbers;

            if (_symbolsCheckBox.Checked)
                groups |= CharacterGroups.SpecialCharacters;

            if (groups != 0)
                return CharacterSets.Get(groups);

            return null;
        }
    }
}
