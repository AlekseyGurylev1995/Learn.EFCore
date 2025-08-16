using System;

using Learn.EFCore.Core.Exceptions.Developers;

namespace Learn.EFCore.Core.VObjects;

public readonly struct PasswordHash : IEquatable<PasswordHash>
{
    public string Value { get; }

    public HashAlgorithmType Algorithm { get; }

    public PasswordHash()
    {
        throw StructEmptyCtorNotAllowedException<PasswordHash>.Create();
    }

    public PasswordHash(string passwordHash, HashAlgorithmType hashAlgorithmType) 
    {
        Value = passwordHash;
        Algorithm = hashAlgorithmType;
    }

    public static PasswordHash Create(
        string passwordHash,
        HashAlgorithmType HashAlgorithmType) 
    {
        var instance = new PasswordHash(passwordHash, HashAlgorithmType);
        return instance;
    }

    public bool Equals(PasswordHash other) 
    {
        return other.Value == Value &&
            other.Algorithm == Algorithm;
    }

    public override bool Equals(object obj)
    {
        return obj is PasswordHash other &&
            Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Algorithm);
    }

    public enum HashAlgorithmType
    {
        Simple = 1 // GetHashCode
    }
}

