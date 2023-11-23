namespace ComplexNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first real number");
            string input=Console.ReadLine();
            if(!int.TryParse(input, out int real1)||input==null) 
            {
                Console.WriteLine("Not Valid number");
                return;
            }
            Console.WriteLine("Enter the first imaginary number");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int imaginary1) || input == null)
            {
                Console.WriteLine("Not Valid number");
                return;
            }
            Complex com1 = new Complex(real1, imaginary1);
            Console.WriteLine("Enter the second real number");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int real2) || input == null)
            {
                Console.WriteLine("Not Valid number");
                return;
            }
            Console.WriteLine("Enter the second imaginary number");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int imaginary2) || input == null)
            {
                Console.WriteLine("Not Valid number");
                return;
            }
            Complex comp2 = new Complex(real2, imaginary2);
            Complex comp3 = com1 + comp2;
            Console.WriteLine("Sum is");
            Console.WriteLine(comp3);
        }
    }
}