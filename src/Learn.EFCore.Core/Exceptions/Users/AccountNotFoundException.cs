using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users;

public class AccountNotFoundException : Exception, IUserException
{
    private AccountNotFoundException(string message)
        : base(message) 
    {

    }

    public static AccountNotFoundException Create() 
    {
        var msg = $"Аккаунт не найден";

        var instance = new AccountNotFoundException(msg);
        return instance;
    }
}

