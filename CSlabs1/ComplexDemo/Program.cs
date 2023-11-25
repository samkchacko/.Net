namespace ComplexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber comp1 = new ComplexNumber(20,30);
            ComplexNumber comp2= new ComplexNumber(40,10);
            ComplexNumber comp3=comp1 + comp2;
            Console.WriteLine(comp3.ToString());
            int? num = null;
            int i = num == null ? 0 : num.Value;
            int j = num ?? 0;//null coalescing operrator(??) 
            bool val=num.HasValue;
            Console.WriteLine(val);
        }
    }
}