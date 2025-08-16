using System;

using Learn.EFCore.Core.Exceptions.Developers;

namespace Learn.EFCore.Core.VObjects.Ids
{
    public readonly struct SessionId : IEquatable<SessionId>
    {
        public Guid Value { get; }

        public SessionId() 
        {
            throw StructEmptyCtorNotAllowedException<SessionId>.Create();
        }

        private SessionId(Guid id) 
        {
            Value = id;
        }

        public static SessionId Create(Guid id) 
        {
            if (id == default) 
            {
                throw DefaultIdException<SessionId>.Create();
            }

            var instance = new SessionId(id);
            return instance;
        }

        public bool Equals(SessionId other) 
        {
            return other.Value == Value;
        }

        public override bool Equals(object obj)
        {
            return obj is SessionId other &&
                Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
