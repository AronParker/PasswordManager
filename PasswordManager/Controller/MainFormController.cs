using PasswordManager.Forms;
using PasswordManager.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Controller
{
    public class MainFormController
    {
        private PasswordBuilder _builder;
        private MainForm _form;
        private string _lastPassphrase;

        public MainFormController()
        {
            _builder = new PasswordBuilder();
            _form = new MainForm();
            _form.ChangeCharacterSet += Form_ChangeCharacterSet;
            _form.CopyPasswordRequested += Form_CopyPasswordRequested;
        }

        public void Run()
        {
            Application.Run(_form);
        }

        private void Form_ChangeCharacterSet(object sender, EventArgs e)
        {
            var characterSet = _form.CharacterSet;

            using (var dialog = new CharacterSetForm(characterSet))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    _form.CharacterSet = dialog.CharacterSet;
            }
        }

        private void Form_CopyPasswordRequested(object sender, EventArgs e)
        {
            var currentPassphrase = _form.Passphrase;

            if (currentPassphrase != _lastPassphrase)
            {
                _builder.Passphrase = currentPassphrase;
                _lastPassphrase = currentPassphrase;
            }

            var tag = _form.PassphraseTag;
            var characterSet = _form.CharacterSet;

            if (characterSet.Length == 0)
            {
                MessageBox.Show("The character set must contain at least 1 character.", "Empty character set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var passwordLength = _form.Length;
            var password = _builder.GetPassword(tag, characterSet, passwordLength);

            Clipboard.SetText(password);
        }


    }
}
