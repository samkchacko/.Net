using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeligateVilla
{
    internal class SMS
    {
        public static void Send(object sender,CustomEventArgs e)
        {
            Console.WriteLine($"SMS sended to {e.MobileNo}");
        }
    }
}
