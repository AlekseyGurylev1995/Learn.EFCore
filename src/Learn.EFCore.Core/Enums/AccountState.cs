namespace Learn.EFCore.Core.Enums;

public enum AccountState
{
    /// <summary>
    ///     Активный
    /// </summary>
    Active = 1,

    /// <summary>
    ///     Не подтвержден (например по эл. почте)
    /// </summary>
    Unconfirmed,

    /// <summary>
    ///     Заблокирован
    /// </summary>
    Blocked
}

