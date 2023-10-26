using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Exceptions
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(string message) : base(message) { }
    }
}
