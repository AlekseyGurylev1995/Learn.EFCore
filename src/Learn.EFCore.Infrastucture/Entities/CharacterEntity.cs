using Learn.EFCore.Core.VObjects;
using Learn.EFCore.Core.VObjects.Ids;

namespace Learn.EFCore.Infrastucture.Entities
{
    internal sealed class CharacterEntity
    {
        public CharacterId Id { get; }

        public AccountId AccountId { get; }

        public CharacterName Name { get; }

        public bool IsOnline { get; }
    }
}
