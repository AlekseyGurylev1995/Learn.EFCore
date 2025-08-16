using Learn.EFCore.Core.VObjects;
using Learn.EFCore.Core.VObjects.Ids;

namespace Learn.EFCore.Application.Abstractions.Repositories;

public interface IAuthDataByLoginRepository
{
    public void CreateAsync(
        Login login,
        AccountId accountId,
        PasswordHash passwordHash);
}

