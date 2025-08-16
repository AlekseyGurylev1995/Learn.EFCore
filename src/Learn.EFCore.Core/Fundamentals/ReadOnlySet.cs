using System;
using System.Collections;
using System.Collections.Generic;

namespace Learn.EFCore.Core.Fundamentals
{
    /// <summary>
    ///     Нужен для: IReadOnlySet Set = _set.AsReadOnly()
    ///         p.s. Почему разрабы .NET этого не добавили
    /// </summary>
    public class ReadOnlySet<T> : IReadOnlySet<T>
    {
        private readonly ISet<T> _source;

        public ReadOnlySet(ISet<T> source)
        {
            ArgumentNullException.ThrowIfNull(source);
            _source = source;
        }

        public int Count => _source.Count;

        public bool Contains(T item)
        {
            return _source.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _source.GetEnumerator();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            return _source.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            return _source.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            return _source.IsSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            return _source.IsSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            return _source.Overlaps(other);
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            return _source.SetEquals(other);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
