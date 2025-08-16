using System.Collections.Generic;

namespace Learn.EFCore.Core.Fundamentals;

public static class ReadOnlySetExtension
{
    /// <summary>
    ///     Нужен для: IReadOnlySet Set = _set.AsReadOnly()
    ///         p.s. Почему разрабы .NET этого не добавили
    /// </summary>
    public static ReadOnlySet<T> AsReadOnly<T>(this ISet<T> source) 
    {
        return new ReadOnlySet<T>(source);
    }
}

