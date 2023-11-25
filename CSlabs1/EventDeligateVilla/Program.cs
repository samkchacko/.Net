namespace EventDeligateVilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.SendCreatedEvent += Email.Send;
            order.SendCreatedEvent += SMS.Send;
            order.created("sam@gmail.com",9567415896);
        }
    }
}