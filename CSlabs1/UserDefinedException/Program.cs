namespace UserDefinedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                string number = "abc";
                int num = Convert.ToInt32(number);
            }
            catch (FormatException e)
            {
                throw new InvalidNumberExeption(e.Message);
            }
        }
    }
}