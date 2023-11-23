internal class Program
{
    private static void Main(string[] args)
    {
        //1
        string name = "sam";
        Console.WriteLine("Welcome "+name);
        //2
        Console.WriteLine("Welcome {0} to the show",name);
        Console.WriteLine(string.Format("Melcow {0} to the race",name));
        //3
        Console.WriteLine($"Welcome {name} here");
    }
}