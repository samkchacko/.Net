using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    delegate void OrderEventHandler();
    internal class Order
    {   //our own event deligate
        //public event OrderEventHandler OnCreated;

        //inbuild deligate
        //public event EventHandler OnCreated;
        public event EventHandler<OrderEventArgs> OnCreated;
        public void Create(string email,long phone)
        {
            Console.WriteLine("Order Placed");
            //Email.Send();
            //SMS.Send();
            if (OnCreated != null)
            {
                //OnCreated(this,EventArgs.Empty);
                OnCreated(this, new OrderEventArgs
                {
                    Email = email,
                    Phone = phone
                });
            }
        }
    }
}
