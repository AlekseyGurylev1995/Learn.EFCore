using System;

using Learn.EFCore.Core.Abstractions;

namespace Learn.EFCore.Core.Exceptions.Users
{
    public class InvalidLoginException : Exception, IUserException
    {
        private InvalidLoginException(string message) : base(message) 
        {

        }

        public static InvalidLoginException Create()
        {
            var msg = "Не валидный логин";

            var instance = new InvalidLoginException(msg);
            return instance;
        }
    }
}
