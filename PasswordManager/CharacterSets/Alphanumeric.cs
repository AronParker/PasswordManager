using static PasswordManager.CharacterSets.CharacterSets;

namespace PasswordManager.CharacterSets
{

    public class Alphanumeric : ICharacterSet
    {
        public string Name => "Alphanumeric";

        public string CharacterSet => LowercaseLetters + UppercaseLetters + Numbers;
    }
}
