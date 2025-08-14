using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Developers
{
    public class DefaultIdException<T> : Exception, IDevException
    {
        private DefaultIdException(string message) 
            : base(message) { }

        public static DefaultIdException<T> Create() 
        {
            var msg = $"Идентификатор для типа {typeof(T).FullName} должен " +
                $"иметь значение отличное от default";

            var instance = new DefaultIdException<T>(msg);
            return instance;
        }
    }
}
