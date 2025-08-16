using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users
{
    public sealed class InvalidCharacterNameException : Exception, IUserException
    {
        private InvalidCharacterNameException(string message)
            : base(message) { }

        public static InvalidCharacterNameException Create() 
        {
            var msg = "Не валидное имя персонажа";

            var instance = new InvalidCharacterNameException(msg);
            return instance;
        }
    }
}
