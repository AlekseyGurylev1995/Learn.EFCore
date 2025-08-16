using Learn.EFCore.Core.VObjects.Ids;
using Learn.EFCore.Core.Primitives;
using Learn.EFCore.Core.VObjects;

namespace Learn.EFCore.Domain.Entities
{
    public sealed class Character : Entity<CharacterId>
    {
        public CharacterName Name { get; private set; }
        public bool IsOnline { get; private set; }

        private Character(CharacterId id, CharacterName name) 
            : base(id) 
        {
            Name = name;
            IsOnline = false;
        }

        public static Character Create(CharacterId id, CharacterName name) 
        {
            var instance = new Character(id, name);
            return instance;
        }

        public void MarkAsOnline() 
        {
            IsOnline = true;
        }

        public void MarkAsOffline() 
        {
            IsOnline = false;
        }

        public void ChangeName(CharacterName newName) 
        {
            Name = newName;
        }
    }
}
