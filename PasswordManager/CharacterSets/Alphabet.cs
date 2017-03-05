using static PasswordManager.CharacterSets.CharacterSets;

namespace PasswordManager.CharacterSets
{
    public class Alphabet : ICharacterSet
    {
        public string Name => "Alphabet";

        public string CharacterSet => LowercaseLetters + UppercaseLetters;
    }
}
