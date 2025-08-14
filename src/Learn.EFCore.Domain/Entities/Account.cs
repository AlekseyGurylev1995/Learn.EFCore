using Learn.EFCore.Core.Enums;
using Learn.EFCore.Core.Ids;
using Learn.EFCore.Core.Primitives;

namespace Learn.EFCore.Domain.Entities;

public sealed class Account : Entity<AccountId>
{
    public AccountState State { get; private set; }

    public Account(AccountId id) : base(id)
    {
        
    }

    public static Account Create(AccountId id) 
    {
        var instance = new Account(id);
        return instance;
    }

    public void MarkAsBlocked() 
    {
        State = AccountState.Blocked;
    }
}

