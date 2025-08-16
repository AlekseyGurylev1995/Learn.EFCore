using System;

using Learn.EFCore.Core.Exceptions.Developers;
using Learn.EFCore.Core.Exceptions.Users;

namespace Learn.EFCore.Core.VObjects
{
    /// <summary>
    ///     Имя персонажа
    /// </summary>
    public readonly struct CharacterName : IEquatable<CharacterName>
    {
        public string Value { get; }

        public CharacterName()
        {
            throw StructEmptyCtorNotAllowedException<CharacterName>.Create();
        }

        private CharacterName(string name) 
        {
            Value = name;
        }

        public static CharacterName Create(string name) 
        {
            Validation(name);

            var instance = new CharacterName(name);
            return instance;
        }

        private static void Validation(string name) 
        {
            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw InvalidCharacterNameException.Create();
            }

            // сюда можно вписать маску,
            // по типу мин. длина, макс. длина
            // возможные символы
            // и всё эти ограничения брать из глобальных настроек
        }

        public bool Equals(CharacterName other) 
        {
            return other.Value == Value;
        }

        public override bool Equals(object obj)
        {
            return obj is CharacterName other &&
                Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
