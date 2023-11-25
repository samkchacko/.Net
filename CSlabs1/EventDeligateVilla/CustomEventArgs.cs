using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeligateVilla
{
    internal class CustomEventArgs:EventArgs
    {
        public string Email { get; set; }
        public long MobileNo { get; set; }
    }
}
