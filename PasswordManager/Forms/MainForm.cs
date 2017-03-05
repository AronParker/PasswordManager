using System;
using System.Windows.Forms;
using PasswordManager.Security;
using PasswordManager.CharacterSets;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        private PasswordBuilder _builder;
        private string _lastPassphrase;

        public MainForm()
        {
            InitializeComponent();

            _builder = new PasswordBuilder();
            _characterSetComboBox.DataSource = new ICharacterSet[] { new Alphabet(),
                                                                     new Alphanumeric(),
                                                                     new AlphanumericSymbols(),
                                                                     new AlphanumericSymbolsSpace() };
            _characterSetComboBox.DisplayMember = "Name";
            _characterSetComboBox.ValueMember = "CharacterSet";
            _characterSetComboBox.SelectedIndex = 2;
        }

        private void ShowPassphraseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _passphraseTextBox.UseSystemPasswordChar = !_showPassphraseCheckBox.Checked;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (_passphraseTextBox.Text != _lastPassphrase)
            {
                _builder.Passphrase = _passphraseTextBox.Text;
                _lastPassphrase = _passphraseTextBox.Text;
            }
            
            var password = _builder.GetPassword(_tagTextBox.Text, (string)_characterSetComboBox.SelectedValue, (int)_lengthNumericUpDown.Value);

            Clipboard.SetText(password);
        }
    }
}
