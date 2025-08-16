using System;

using Learn.EFCore.Core.Exceptions.Developers;
using Learn.EFCore.Core.Extensions;

namespace Learn.EFCore.Core.VObjects.Ids;

public readonly struct CharacterId : IEquatable<CharacterId>
{
    public long Value { get; }

    public CharacterId() 
    {
        throw StructEmptyCtorNotAllowedException<CharacterId>.Create();
    }

    private CharacterId(long id) 
    {
        Value = id;
    }

    public static CharacterId Create(long id) 
    {
        if (id.IsNotPositive()) 
        {
            throw NotPositiveIdException<CharacterId>.Create();
        }

        var instance = new CharacterId(id);
        return instance;
    }

    public bool Equals(CharacterId other)
    {
        return other.Value == Value;
    }

    public override bool Equals(object obj)
    {
        return obj is CharacterId other
            && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}

