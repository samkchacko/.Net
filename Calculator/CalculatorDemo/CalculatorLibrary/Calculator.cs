namespace CalculatorLibrary
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public static double add(double num1,double num2)
        {
            return num1 + num2;
        }
        public static double substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double divison(double num1, double num2)
        {
            return num1/num2;
        }
        public static double multipliction(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}