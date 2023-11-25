using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Email
    {
        public static void Send(Object sender,OrderEventArgs e)
        {
            Console.WriteLine($"Email Send to {e.Email}");
        }
    }
}
