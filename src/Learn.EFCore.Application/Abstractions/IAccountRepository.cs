using System.Threading.Tasks;

using Learn.EFCore.Core.VObjects.Ids;
using Learn.EFCore.Core.VObjects;

namespace Learn.EFCore.Application.Abstractions;

public interface IAccountRepository
{
    public Task<AccountId> CreateByLoginAsync(Login login, Password password);
}

