namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Order order = new Order();
            //subscribe to the event
            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            order.Create("sam@gmail.com",9567415896);
        }
    }
}