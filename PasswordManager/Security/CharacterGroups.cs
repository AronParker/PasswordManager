using System;

namespace PasswordManager.Security
{
    [Flags]
    public enum CharacterGroups
    {
        Numbers = 1,
        UppercaseLetters = 2,
        LowercaseLetters = 4,
        SpecialCharacters = 8,
        All = Numbers | UppercaseLetters | LowercaseLetters | SpecialCharacters
    }
}
