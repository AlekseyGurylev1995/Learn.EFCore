using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Developers;

public class NotPositiveIdException<T> : Exception, IDevException
    where T: struct
{
    private NotPositiveIdException(string message) 
        : base(message) { }

    public static NotPositiveIdException<T> Create() 
    {
        var msg = $"Идентификатор для типа {typeof(T).FullName} должен быть положительным";

        var instance = new NotPositiveIdException<T>(msg);
        return instance;
    }
}

