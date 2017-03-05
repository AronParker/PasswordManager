using static PasswordManager.CharacterSets.CharacterSets;

namespace PasswordManager.CharacterSets
{

    public class AlphanumericSymbols : ICharacterSet
    {
        public string Name => "Alphanumeric + Symbols";

        public string CharacterSet => LowercaseLetters + UppercaseLetters + Numbers + Symbols;
    }
}
