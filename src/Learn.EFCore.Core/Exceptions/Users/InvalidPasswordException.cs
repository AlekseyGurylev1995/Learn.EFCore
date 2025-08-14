using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users
{
    public class InvalidPasswordException : Exception, IUserException
    {
        private InvalidPasswordException(string message) : base(message) 
        {

        }

        public static InvalidPasswordException Create()
        {
            var msg = "Не валидный пароль";

            var instance = new InvalidPasswordException(msg);
            return instance;
        }
    }
}
