using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeligateVilla
{
    internal class Email
    {
        public static void Send(object sender,CustomEventArgs e)
        { 
            Console.WriteLine($"Email Sended to {e.Email}");
        }
    }
}
