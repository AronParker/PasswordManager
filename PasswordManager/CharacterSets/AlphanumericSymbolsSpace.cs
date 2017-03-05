using static PasswordManager.CharacterSets.CharacterSets;

namespace PasswordManager.CharacterSets
{

    public class AlphanumericSymbolsSpace : ICharacterSet
    {
        public string Name => "Alphanumeric + Symbols + Space";

        public string CharacterSet => LowercaseLetters + UppercaseLetters + Numbers + Symbols + Space;
    }
}
