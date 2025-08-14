using System;

using Learn.EFCore.Core.Exceptions;
using Learn.EFCore.Core.Extensions;

namespace Learn.EFCore.Core.Ids;

public readonly struct AccountId : IEquatable<AccountId>
{
    public long Value { get; }

    public AccountId() 
    {
        throw StructEmptyCtorNotAllowedException<AccountId>.Create();
    }

    private AccountId(long id) 
    {
        Value = id;
    }

    public static AccountId Create(long id) 
    {
        if (id.IsNotPositive()) 
        {
            throw NotPositiveIdException<AccountId>.Create();
        }

        var instance = new AccountId(id);
        return instance;
    }

    public bool Equals(AccountId other)
    {
        return other.Value == Value;
    }

    public override bool Equals(object obj)
    {
        return obj is AccountId other
            && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}

