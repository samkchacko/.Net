namespace AssignmentsDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nEnter the Option\n0-->Even\n1-->Odd\n2-->Prime\n3-->Fabinocci Series\n4-->Exit\n\n");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int option) || input == null)
                {
                    Console.WriteLine("Invalid Number");
                    return;
                }
                switch (option)
                {
                    case 0:
                        HandleEven();
                        break;
                    case 1:
                        HandleOdd();
                        break;
                    case 2:
                        HandlePrime();
                        break;
                    case 3:
                        HandleFabinocci();
                        break;
                    case 4:
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        static void HandleEven()
        {
            int[] arr=new int[10];
            for(int i = 0; i < 10; i++) {
                Console.WriteLine("Enter the number");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int number) || input == null)
                {
                    Console.WriteLine("Invalid Number");
                    return;
                }
                arr[i] = number;

            }
            
            OddEvenPrimeFibinocci obj = new Implement(arr);
            obj.Even();
        }
        static void HandleOdd()
        {
            int[] arr = new int[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Enter the number");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int number) || input == null)
                {
                    Console.WriteLine("Invalid Number");
                    return;
                }
                arr[i] = number;

            }
            OddEvenPrimeFibinocci obj = new Implement(arr);
            obj.Odd();
        }
        static void HandlePrime()
        {
            Console.WriteLine("Enter the number");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number) || input == null)
            {
                Console.WriteLine("Invalid Number");
                return;
            }
            OddEvenPrimeFibinocci obj = new Implement(number);
            if (obj.Prime())
            {
                Console.WriteLine($"{number} is Prime");
            }
            else Console.WriteLine($"{number} is not Prime");
        }
        static void HandleFabinocci()
        {
            Console.WriteLine("Enter the number");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number) || input == null)
            {
                Console.WriteLine("Invalid Number");
                return;
            }
            OddEvenPrimeFibinocci obj = new Implement(number);
            obj.Fibinocci();
        }
    }
}