using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeligateVilla
{
    //delegate void SendEvent();
    delegate void EventHandler(object sender, EventArgs e);
    internal class Order
    {
        //public event SendEvent SendCreatedEvent;
        public event EventHandler<CustomEventArgs>SendCreatedEvent;
        public void created(String email,long phone)
        {
            Console.WriteLine("Order created");
            if(SendCreatedEvent != null) 
            {
                /*SendCreatedEvent(this,EventArgs.Empty)*/;
                SendCreatedEvent(this,new CustomEventArgs(){
                    Email = email,
                    MobileNo = phone
                });
            }

        }
    }
}
