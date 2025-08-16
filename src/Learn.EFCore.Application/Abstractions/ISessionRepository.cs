using System.Threading.Tasks;

using Learn.EFCore.Core.VObjects.Ids;
using Learn.EFCore.Domain.Entities;

namespace Learn.EFCore.Application.Abstractions;

public interface ISessionRepository
{
    // TODO: нужно по BL следить, чтобы не было ситуации,
    // когда у нас будет более 1 активной сессии
    public Task<Session> GetLastActiveAsync(AccountId accountId);

    public Task<Session> CreateAsync(AccountId accountId);
}

