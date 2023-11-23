namespace DelegateDemo
{
    //1
    public delegate void MathDelegate(int num1,int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            MathDelegate mathDel = Add;
            MathDelegate mathDel2 = new MathDelegate(Add);
            MathDelegate mathDel3 = Add;
            //multiDelegates
            mathDel3 += Substract;
            mathDel3 += Multiplication;
            mathDel3 += Division;

            //4
            mathDel(2, 3);
            mathDel2(10, 20);
            mathDel3(10, 3);
        }
        //2
        public static void Add(int num1,int num2) 
        {
            Console.WriteLine("Addition");
            Console.WriteLine(num1+num2);
        }
        public static void Substract(int num1,int num2) 
        {
            Console.WriteLine("Substraction");
            Console.WriteLine(num1-num2);
        }
        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine(num1 * num2);
        }
        public static void Division(int num1, int num2)
        {
            Console.WriteLine("Division");
            Console.WriteLine(num1 / num2);
        }
    }
}