using System;

using Learn.EFCore.Core.Exceptions.Developers;
using Learn.EFCore.Core.Exceptions.Users;

namespace Learn.EFCore.Core.VObjects;

public readonly struct Password : IEquatable<Password>
{
    public string Value { get; }

    public Password() 
    {
        throw StructEmptyCtorNotAllowedException<Password>.Create();
    }

    private Password(string password) 
    {
        Value = password;
    }

    public static Password Create(string password) 
    {
        Validate(password);

        var instance = new Password(password);
        return instance;
    }

    private static void Validate(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw InvalidPasswordException.Create();
        }

        // сюда можно вписать маску,
        // по типу мин. длина, макс. длина
        // возможные символы
        // и всё это брать из глобальных настроек
    }

    public bool Equals(Password other)
    {
        return other.Value == Value;
    }

    public override bool Equals(object obj)
    {
        return obj is Password other &&
            Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
