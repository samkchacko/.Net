using CalculatorLibrary;

namespace CalculatorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //select the operation
            Console.WriteLine("Which opertion you want to perform");
            Console.WriteLine("1->Add,2->Substract,3->Division,4->Multiplication,0->>Exit");
            string option = Console.ReadLine();
            if (!int.TryParse(option, out int value) || option == null || value < 0 || value > 4)
            {
                Console.WriteLine("Invalid option");
                return;
            }
            if (value == 0)
            {
                Console.WriteLine("Exiting");
                return;
            }
            //input the first value
            Console.WriteLine("enter the first Number {0}");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double num1))
            {
                Console.WriteLine("Invalid Number");
                return;
            }
            //inputthe second number
            Console.WriteLine("enter the second Number");
            input = Console.ReadLine();
            if (!double.TryParse(input, out double num2) || (value == 3) && num2 == 0)
            {
                Console.WriteLine("Invalid number or dividing by zero");
                return;
            }
            //switch cases
            switch (value)
            {
                case 1:
                    Console.WriteLine("Sum is --> "+Calculator.add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Difference is --> "+Calculator.substract(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Quotient is --> "+Calculator.divison(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Product is --> "+Calculator.multipliction(num1, num2));
                    break;
                default:
                    Console.WriteLine("Exiting");
                    break;

            }
        }
    }
}