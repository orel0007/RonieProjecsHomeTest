using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class InvalidFileFormatException : Exception
{
    public InvalidFileFormatException() { }

    public InvalidFileFormatException(string message)
        : base(message) { }

    public InvalidFileFormatException(string message, Exception inner)
        : base(message, inner) { }
}