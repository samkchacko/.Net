using System.Text.RegularExpressions;

namespace EmployeeDataTypeValid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the id");
            string input=Console.ReadLine();
            if (!int.TryParse(input,out int id)||id<0)
            {
                Console.WriteLine("Invalid ID");
                return;
            }
            if (id < 0)
            {
                Console.WriteLine("Id should be greater than 0");
                return;
            }
            Employee emp=new Employee();
            emp.Id = id;

            Console.WriteLine("Enter the name");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)||!Regex.IsMatch(input,"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Emply or Null or Not a string");
                return;
            }
            emp.name = input;
            DateTime minDate = new DateTime(1985, 12, 30);
            Console.WriteLine("Enter the Date of Birth");
            input = Console.ReadLine();
            if (!DateTime.TryParse(input,out DateTime date)||date<minDate||date>DateTime.Now)
            {
                Console.WriteLine("Empty or Null or Ivalid date given");
                return;
            }
            emp.BirthDate = date;

            Console.WriteLine("Enter the Email");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)||!Regex.IsMatch(input, "^[a-zA-Z0-9]+(?:\\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z0-9]+)*$"))
            {
                Console.WriteLine("Invalid Email or Email Format");
                return;
            }
            emp.email = input;
        }
    }
}