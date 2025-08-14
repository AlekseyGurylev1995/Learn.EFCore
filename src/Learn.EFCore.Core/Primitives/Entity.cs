namespace Learn.EFCore.Core.Primitives;

public abstract class Entity<T>
    where T: struct
{
    protected T Id { get; }

    protected Entity(T id)
    {
        Id = id;
    }

    /// <summary>
    ///     Переопределяем, для того сравнивать класс как значимый тип,
    ///     поскольку:
    ///         один экз. всегда живёт в Domain слое
    ///         остальные могут создаватся в слое Infrastructure
    /// </summary>
    public override bool Equals(object obj)
    {
        if (object.ReferenceEquals(obj, this)) 
        {
            return true;
        }

        if (obj is not Entity<T> other) 
        {
            return false;
        }

        return Id.Equals(other.Id);
    }

    /// <summary>
    ///     Переопределяем, для того сравнивать класс как значимый тип,
    ///     поскольку:
    ///         один экз. всегда живёт в Domain слое
    ///         остальные могут создаватся в слое Infrastructure
    /// </summary>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

