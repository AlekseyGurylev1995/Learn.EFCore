using System;

using Learn.EFCore.Core.Enums;
using Learn.EFCore.Core.VObjects.Ids;
using Learn.EFCore.Core.Primitives;

namespace Learn.EFCore.Domain.Entities
{
    public sealed class Session : Entity<SessionId>
    {
        /// <summary>
        ///     Текущее состояние сессии
        /// </summary>
        public SessionState State { get; private set; }

        /// <summary>
        ///     DATETIME выхода пользователя из системы
        /// </summary>
        public DateTime? LoggedOutAt { get; private set; }

        /// <summary>
        ///     DATETIME создания сессии
        /// </summary>
        public DateTime CreatedAt { get; }

        /// <summary>
        ///     Идентификатор аккаунта к которому принадлежит сессия
        /// </summary>
        public AccountId AccountId { get; }

        private Session(
            SessionId id,
            SessionState state,
            DateTime timestamp,
            AccountId accountId) : base(id)
        {
            State = state;
            AccountId = accountId;
        }


        public static Session Create(SessionId id, AccountId accountId) 
        {
            var instance = new Session(
                id,
                SessionState.Active,
                DateTime.UtcNow,
                accountId);

            return instance;
        }

        public void SignOut() 
        {
            State = SessionState.NotActive;
            LoggedOutAt = DateTime.UtcNow;
        }
    }
}
