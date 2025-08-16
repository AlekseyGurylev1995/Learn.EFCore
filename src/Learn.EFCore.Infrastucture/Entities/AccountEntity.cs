using Learn.EFCore.Core.Enums;
using Learn.EFCore.Core.VObjects.Ids;

namespace Learn.EFCore.Infrastucture.Entities
{
    internal sealed class AccountEntity
    {
        public AccountId Id { get; }

        public AccountState State { get; }
    }
}
