using System;

using Learn.EFCore.Core.Abstractions;
using Learn.EFCore.Core.VObjects;

namespace Learn.EFCore.Infrastucture.Security;

public class PasswordHasher : IPasswordHasher
{
    public PasswordHash Hash(
        Password password,
        PasswordHash.HashAlgorithmType hashAlgorithmType)
    {
        string strPasswordHash;
        if (hashAlgorithmType == PasswordHash.HashAlgorithmType.Simple) 
        {
            strPasswordHash = password.GetHashCode().ToString();
            var passwordHash = PasswordHash.Create(strPasswordHash, hashAlgorithmType);
            return passwordHash;
        }

        throw new NotImplementedException();
    }

    public bool Verify(Password password, PasswordHash passwordHash)
    {
        if (passwordHash.Algorithm == PasswordHash.HashAlgorithmType.Simple) 
        {
            var result = password.GetHashCode().ToString() == passwordHash.Value;
            return result;
        }

        throw new NotImplementedException();
    }
}

