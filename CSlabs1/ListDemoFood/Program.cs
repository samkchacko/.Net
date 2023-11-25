namespace ListDemoFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> recipie = new List<string>();
            Console.WriteLine(recipie.Capacity);
            recipie.Add("Vada");
            recipie.Add("FriedRice");
            recipie.Add("Burger");
            recipie.Add("Dosa");
            recipie.Add("chaptti");
            Console.WriteLine(recipie.Count);
            Console.WriteLine(recipie.Capacity);
            recipie.Add("Burger");
            recipie.Add("Dosa");
            recipie.Add("chaptti");
            recipie.Add("Vada");
            Console.WriteLine(recipie.Count);
            Console.WriteLine(recipie.Capacity);
            foreach (var item in recipie)
            {
                Console.WriteLine(item);
            }
            recipie.Clear();
            Console.WriteLine(recipie.Capacity);
            List<int> numbers = new List<int>()//////Collection initilalizer--> bcus we declare and initialize together 
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
            };
        }
    }
}