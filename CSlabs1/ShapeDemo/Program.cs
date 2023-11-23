using System.Diagnostics;

namespace ShapeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("1-->Circle\n2-->Rectangle\n3-->Triangle\n4-->Trapezium\n5-->Square\n6-->Exit");
                string input=Console.ReadLine();
                if(!int.TryParse(input, out int option)||input==null)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        HandleCircle();
                        break;
                     case 2:
                        HandleRectangle();
                        break;
                    case 3:
                        HandleTriangle();
                        break;
                    case 4:
                        HandleTrapezium();
                        break;
                    case 5:
                        HandleRectangle();
                        break;
                    case 6:
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
        }
        static void HandleCircle()
        {
            Console.WriteLine("Enter the radius");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double radius) || input == null)
            {
                Console.WriteLine("Not a valid number");
                    return;
            }
            Circle circle1 = new Circle(radius);
            double area = circle1.Area();
            Console.WriteLine($"Area of circle is {area}");
        }
        static void HandleRectangle()
        {
                Console.WriteLine("Enter the Length");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out double Length) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                Console.WriteLine("Enter the Breadth");
                input = Console.ReadLine();
                if (!double.TryParse(input, out double Breadth) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                shape rectangle = new Rectangle(Length, Breadth);
                double area = rectangle.Area();
                Console.WriteLine($"Area of the rectangle is {area}");
            }
            static void HandleTriangle()
            {
                Console.WriteLine("Enter the BaseLength");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out double baseLength) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                Console.WriteLine("Enter the Height");
                input = Console.ReadLine();
                if (!double.TryParse(input, out double height) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                shape triangle = new Triangle(baseLength,height);
                double area = triangle.Area();
                Console.WriteLine($"Area of the triangle is {area}");
            }
            static void HandleTrapezium()
            {
                Console.WriteLine("Enter the BaseLength");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out double baseLength) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                Console.WriteLine("Enter the UpperLength");
                input = Console.ReadLine();
                if (!double.TryParse(input, out double upperLength) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                Console.WriteLine("Enter the Height");
                input = Console.ReadLine();
                if (!double.TryParse(input, out double height) || input == null)
                {
                    Console.WriteLine("Not a valid number");
                    return;
                }
                shape trapezium = new Trapezium(upperLength,baseLength, height);
                double area = trapezium.Area();
                Console.WriteLine($"Area of the trapezium is {area}");
            }
        }
    }
}