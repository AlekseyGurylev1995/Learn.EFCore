using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Learn.EFCore.Core.Ids;
using Learn.EFCore.Core.Primitives;

namespace Learn.EFCore.Domain.Entities
{
    public sealed class Character : Entity<CharacterId>
    {
        private Character(CharacterId id) : base(id) 
        {

        }

        public static Character Create(CharacterId id) 
        {
            var instance = new Character(id);
            return instance;
        }
    }
}
