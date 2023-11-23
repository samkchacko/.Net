internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number");
        string input1=Console.ReadLine();
        if(!int.TryParse(input1, out int input2))
        {
            Console.WriteLine("Invalid Input");
        }
        //int input2=int.Parse(input1);
        Console.WriteLine("Enter the second number");
        input1=Console.ReadLine();
        if (!int.TryParse(input1,out int input3))
        {
            Console.WriteLine("Invalid input");
        }
        int sum = input3 + input2;
        Console.WriteLine("SUM=" +sum);
        string number = "123";
        int num = Convert.ToInt32(number);
        Console.WriteLine(num + 1);
    }
}