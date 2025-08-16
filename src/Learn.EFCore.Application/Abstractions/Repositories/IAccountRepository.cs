using System.Threading.Tasks;

using Learn.EFCore.Core.VObjects.Ids;
using Learn.EFCore.Core.Enums;

namespace Learn.EFCore.Application.Abstractions.Repositories;

public interface IAccountRepository
{
    public Task<AccountId> CreateAsync(AccountState state);
}

