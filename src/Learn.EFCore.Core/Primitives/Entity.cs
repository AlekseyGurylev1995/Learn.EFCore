using System.Runtime.Serialization;

namespace Learn.EFCore.Core.Primitives
{
    public abstract class Entity<T>
        where T: struct
    {
        public T Id { get; }

        public Entity(T id)
        {
            Id = id;
        }
    }
}
