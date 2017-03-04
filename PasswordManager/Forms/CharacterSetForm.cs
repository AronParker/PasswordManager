using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class CharacterSetForm : Form
    {
        private const string Numbers = "0123456789";
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const char Space = ' ';
        private const string Symbols = "!\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";

        public CharacterSetForm() : this(String.Empty)
        {
        }

        public CharacterSetForm(string characterSet)
        {
            if (characterSet == null)
                throw new ArgumentNullException(nameof(characterSet));

            InitializeComponent();

            _uppercaseCheckBox.Checked = characterSet.Contains(UppercaseLetters);
            _lowercaseCheckBox.Checked = characterSet.Contains(LowercaseLetters);
            _numbersCheckBox.Checked = characterSet.Contains(Numbers);
            _spaceCheckBox.Checked = characterSet.IndexOf(Space) >= 0;
            _symbolsCheckBox.Checked = characterSet.Contains(Symbols);
        }

        public string CharacterSet
        {
            get
            {
                var sb = new StringBuilder();

                if (_uppercaseCheckBox.Checked)
                    sb.Append(UppercaseLetters);

                if (_lowercaseCheckBox.Checked)
                    sb.Append(LowercaseLetters);

                if (_numbersCheckBox.Checked)
                    sb.Append(Numbers);

                if (_spaceCheckBox.Checked)
                    sb.Append(Space);

                if (_symbolsCheckBox.Checked)
                    sb.Append(Symbols);

                return sb.ToString();

            }
        }
    }
}
