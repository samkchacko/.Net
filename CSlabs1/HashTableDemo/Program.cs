using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictonary-->Hashtable
            string input;
            Hashtable dict = new Hashtable();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter UserID");
                input = Console.ReadLine();
                if (!int.TryParse(input, out int key))
                {
                    Console.WriteLine("Invalid Input");
                    i--;
                    continue;
                }
                Console.WriteLine("Enter name");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid Input");
                    i--;
                    continue;
                }
                dict[key] = input;
                //dict.Add(key, input);
            }
            //foreach(var key in dict.Keys) 
            //{
            //    Console.WriteLine($"{key}-->{dict[key]}");
            //}
            foreach (DictionaryEntry de in dict)
            {
                Console.WriteLine($"{de.Key}-->{de.Value}");
            }
            Console.WriteLine("Enter UserID");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int key2))
            {
                Console.WriteLine("Invalid Input");               
            }
            if(dict.ContainsKey(key2))
            {
                Console.WriteLine($"User Found\nname is-->{dict[key2]}");
            }
            else Console.WriteLine("User not found");
        }
    }
}