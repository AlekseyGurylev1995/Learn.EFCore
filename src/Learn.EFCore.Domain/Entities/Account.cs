using Learn.EFCore.Core.Enums;
using Learn.EFCore.Core.VObjects.Ids;
using Learn.EFCore.Core.Primitives;
using System.Collections.Generic;
using Learn.EFCore.Core.Fundamentals;

namespace Learn.EFCore.Domain.Entities;

public sealed class Account : Entity<AccountId>
{
    public AccountState State { get; private set; }
    public IReadOnlySet<CharacterId> CharacterIds
        => _characterIds.AsReadOnly();

    private readonly HashSet<CharacterId> _characterIds;

    public Account(AccountId id) : base(id)
    {
        State = AccountState.Unconfirmed;
        _characterIds = new HashSet<CharacterId>();
    }

    public static Account Create(AccountId id) 
    {
        var instance = new Account(id);
        return instance;
    }

    public void ChangeState(AccountState newState) 
    {
        State = newState;
    }

    public void AddCharacter(CharacterId characterId) 
    {
        _characterIds.Add(characterId);
    }

    public void RemoveCharacter(CharacterId characterId) 
    {
        _characterIds.Remove(characterId);
    }
}

