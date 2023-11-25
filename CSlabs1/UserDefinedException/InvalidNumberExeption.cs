using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class InvalidNumberExeption : ApplicationException
    {
        public InvalidNumberExeption()
        {

        }

        public InvalidNumberExeption(string? message) : base(message)
        {

        }

        public InvalidNumberExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidNumberExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
