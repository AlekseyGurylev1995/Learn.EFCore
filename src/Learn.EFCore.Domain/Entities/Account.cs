using Learn.EFCore.Core.Ids;
using Learn.EFCore.Core.Primitives;

namespace Learn.EFCore.Domain.Entities;

public class Account : Entity<AccountId>
{
    public Account(AccountId id) : base(id)
    {

    }

    public static Account Create(AccountId id) 
    {
        var instance = new Account(id);
        return instance;
    }
}

