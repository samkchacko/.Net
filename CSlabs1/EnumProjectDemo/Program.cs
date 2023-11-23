namespace EnumProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDays day=WeekDays.Monday;
            int[] numbers=new int[7];
            int[] newNumber = {1,2,3,4,5,6,7};
            //for (int i = 0; i < newNumber.Length; i++)
            //{
            //    Console.WriteLine($"number is {newNumber[i]}");
            //}
            foreach (var num in newNumber)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(day);
            switch (day)
            {
                case WeekDays.Sunday:
                    break;
                case WeekDays.Monday:
                    break;
                case WeekDays.Tuesday:
                    break;
                case WeekDays.Wednesday:
                    break;
                case WeekDays.Thursday:
                    break;
                case WeekDays.Friday:
                    break;
                case WeekDays.Saturday:
                    break;
                default:
                    break;
            }
        }
    }
}