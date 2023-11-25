namespace CSharp3Feature
{
    internal class Program
    {
       /* var a = 10;*///not possible
        static void Main(string[] args)
        {
            var i = 10;
            /*var message;*///not possible
            var product = new
            {
                id = 1,
                name = "bike",
                price = 100
            };

            Customer customer = new Customer(1)
            {
                //CustomerId = 1,
                Name = "Sam",
                City = "Kottayam"
            };
            Customer customer2 = new Customer(2)
            {

                //CustomerId = 2,
                Name = "Ankth",
                City = "Ernakulam"
            };
            var customer3 = new Customer(4)
            {
                Name="Anshiq",
                City="Palakad"
            };
            List<Customer> list = new List<Customer>()
            {
                customer,customer2,new Customer(3)
                {
                    Name="Evana",
                    City="Ernakulam"
                }
            };
            string number = "123";
            //int num = number.ToString();
            //method(19);//not possible
            
        }
        //static void method(var k)//not possible
        //{
        //    Console.WriteLine(k);
        //}
    }

}