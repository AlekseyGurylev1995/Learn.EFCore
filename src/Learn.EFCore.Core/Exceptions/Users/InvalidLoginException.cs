using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users
{
    public class InvalidLoginException : Exception, IUserException
    {
        private const string TITLE = "Не валидный логин.\n";

        private InvalidLoginException(string message) : base(message) 
        {

        }

        public static InvalidLoginException Create()
        {
            var msg = TITLE;

            var instance = new InvalidLoginException(msg);
            return instance;
        }

        public static InvalidLoginException Create(string message) 
        {
            var msg = TITLE + message;

            var instance = new InvalidLoginException(msg);
            return instance;
        }
    }
}
