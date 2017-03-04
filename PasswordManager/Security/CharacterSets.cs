using System;
using System.Text;

namespace PasswordManager.Security
{
    public static class CharacterSets
    {
        private const string Numbers = "0123456789";
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialCharacters = " !\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
        private static string[] _characterSets;

        static CharacterSets()
        {
            _characterSets = new string[(int)CharacterGroups.All];

            var sb = new StringBuilder(Numbers.Length + LowercaseLetters.Length + UppercaseLetters.Length + SpecialCharacters.Length);

            for (var i = 1; i <= (int)CharacterGroups.All; i++)
            {
                if ((i & (int)CharacterGroups.Numbers) != 0)
                    sb.Append(Numbers);

                if ((i & (int)CharacterGroups.UppercaseLetters) != 0)
                    sb.Append(UppercaseLetters);

                if ((i & (int)CharacterGroups.LowercaseLetters) != 0)
                    sb.Append(LowercaseLetters);

                if ((i & (int)CharacterGroups.SpecialCharacters) != 0)
                    sb.Append(SpecialCharacters);

                _characterSets[i - 1] = sb.ToString();
                sb.Clear();
            }
        }

        public static string Get(CharacterGroups groups)
        {
            if (groups < CharacterGroups.Numbers || groups > CharacterGroups.All)
                throw new ArgumentOutOfRangeException(nameof(groups));
            
            return _characterSets[(int)groups - 1];
        }
    }
}
