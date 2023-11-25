using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class SMS
    {
        //public static void Send(Object sender, EventArgs e)
        public static void Send(Object sender, OrderEventArgs e)
        {
            
            Console.WriteLine($"SMS Send to {e.Phone}");

        }
    }
}
