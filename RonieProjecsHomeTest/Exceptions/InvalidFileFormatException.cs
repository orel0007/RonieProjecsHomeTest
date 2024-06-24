using System;

namespace RonieProjecsHomeTest.Exceptions
{
    public class InvalidFileFormatException : Exception
    {
        // Default constructor
        public InvalidFileFormatException()
        {
        }

        // Constructor that accepts a custom message
        public InvalidFileFormatException(string message)
            : base(message)
        { }

        // Constructor that accepts a custom message and an inner exception
        public InvalidFileFormatException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}

