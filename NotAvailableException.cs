using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class NotAvailableException:Exception
    {

        public NotAvailableException(string message)
            : base(message)
        {
        }

        public NotAvailableException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
