namespace DictionaryUserDemo
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, double>> currency = new Dictionary<string, Dictionary<string, double>>();
        static void Main(string[] args)
        {

            //{
            //    { "inr","indian rupee" },
            //    {"usd","us dollar" },
            //    {"sgd","singapore dolar"},
            //    {"eur","euro" }
            //};
            //Dictionary<string,double> conversion= new Dictionary<string, double>()
            //Dictionary<string, KeyValuePair<string, double>> currencies = new Dictionary<string, KeyValuePair<string, double>>()
            //{
            //    { "INR",new KeyValuePair<string,double>("USD",0.017) },
            //    { "USD",new KeyValuePair<string,double>("INR",0.83) },
            //    { "INR",new KeyValuePair<string,double>("SGD",0.017) },
            //};
            AddCurrencyRate("USD", "INR", 83);
            AddCurrencyRate("INR", "USD", .07);
            AddCurrencyRate("SGC", "INR", 200);
            Console.WriteLine("Enter the source Currency");
            string source = Console.ReadLine().ToUpper();
            if (string.IsNullOrEmpty(source) || !currency.ContainsKey(source))
            {
                Console.WriteLine("Not a valid Currency");
                return;
            }
            Console.WriteLine("Enter the source Currency");
            string target = Console.ReadLine().ToUpper();
            if (string.IsNullOrEmpty(target) || !currency[source].ContainsKey(target))
            {
                Console.WriteLine("Not a valid Currency");
            }
            Console.WriteLine("Enter the Amount");
            string input = Console.ReadLine().ToUpper();
            if (!int.TryParse(input,out int value)||input==null)
            {
                Console.WriteLine("Not a valid Currency");
                return;
            }
            Console.WriteLine($"Convert amount of {value} {source} to {target} is {convert(value,source,target)}");
        }
        static void AddCurrencyRate(string source,string target,double rate)
        {
            if (!currency.ContainsKey(source))
            {
                currency[source] = new Dictionary<string, double>();
            }
            currency[source][target] = rate;
        }
        static double convert(double amount,string source,string target)
        {
            if (currency.ContainsKey(source) && currency[source].ContainsKey(target))
            {
                double ExchnageRate = amount * currency[source][target];
                return ExchnageRate;
            }
            else
            {
                Console.WriteLine("Currency Exchage not possible");
                return 0;
            }
        }

    }
}