using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users;

public class AccountAlreadyExistsException : Exception, IUserException
{
    private AccountAlreadyExistsException(string message) : base(message) 
    {

    }

    public static AccountAlreadyExistsException Create() 
    {
        var msg = "Аккаунт уже существует";

        var instance = new AccountAlreadyExistsException(msg);
        return instance;
    }
}

