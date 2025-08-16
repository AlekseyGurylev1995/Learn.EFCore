using Learn.EFCore.Core.VObjects;

namespace Learn.EFCore.Core.Abstractions;

public interface IPasswordHasher
{
    PasswordHash Hash(
        Password password,
        PasswordHash.HashAlgorithmType hashAlgorithmType);

    bool Verify(Password password, PasswordHash passwordHash);
}

