using System;

namespace Tema9Ej3
{
    internal class NegativePriceException : Exception
    {
        public NegativePriceException() { }

        public NegativePriceException(string message) : base(message) { }

        public NegativePriceException(string message, Exception innerException) : base(message, innerException) { }
    }
}