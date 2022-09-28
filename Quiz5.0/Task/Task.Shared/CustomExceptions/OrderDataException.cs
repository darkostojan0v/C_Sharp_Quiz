using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Shared.CustomExceptions
{
    public class OrderDataException : Exception
    {
        public OrderDataException(string message) : base(message)
        {

        }
    }
}
