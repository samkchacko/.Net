namespace ClassTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class6 instance6 = new Class6();
            instance6.name = "Test";
            Class6.RollNo();
            
        }
    }
    //sealed class Class1 
    //{

    //}
    //class Class2 :Class1
    //{

    //}
    //static class Class3
    //{

    //}
    //class class4:Class3
    //{

    //}
    partial class class5
    {

    }
    partial class class5
    {

    }
    class  Class6
    {
        int id;
        public string name { get; set; }
        public void MethodName()
        {

        }
        public static void RollNo()
        {

        }
    }
}