using System;

using Learn.EFCore.Core.Exceptions.Developers;
using Learn.EFCore.Core.Exceptions.Users;

namespace Learn.EFCore.Application.UseCases.Commands.CreateAccountByLogin.Parameters;

public readonly struct Login : IEquatable<Login>
{
    public string Value { get; }

    public Login() 
    {
        throw StructEmptyCtorNotAllowedException<Login>.Create();
    }

    private Login(string login) 
    {
        Value = login;
    }

    public static Login Create(string login) 
    {
        Validate(login);

        var instance = new Login(login);
        return instance;
    }

    private static void Validate(string login) 
    {
        if (string.IsNullOrWhiteSpace(login)) 
        {
            throw InvalidLoginException.Create();
        }

        // сюда можно вписать маску,
        // по типу мин. длина, макс. длина
        // возможные символы
        // и всё это брать из глобальных настроек
    }

    public bool Equals(Login other) 
    {
        return other.Value == Value;
    }

    public override bool Equals(object obj)
    {
        return obj is Login other
            && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}

