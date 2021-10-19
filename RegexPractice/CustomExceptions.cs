using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPractice
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_EMAIL, INVALID_MOBILENUMBER, INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        public CustomExceptions(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
