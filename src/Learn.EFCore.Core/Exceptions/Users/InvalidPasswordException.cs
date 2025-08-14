using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users
{
    public class InvalidPasswordException : Exception, IUserException
    {
        private const string TITLE = "Не валидный пароль.\n";

        private InvalidPasswordException(string message) : base(message) 
        {

        }

        public static InvalidPasswordException Create()
        {
            var msg = TITLE;

            var instance = new InvalidPasswordException(msg);
            return instance;
        }

        public static InvalidPasswordException Create(string message) 
        {
            var msg = TITLE + message;

            var instance = new InvalidPasswordException(msg);
            return instance;
        }
    }
}
