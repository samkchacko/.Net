namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 12;
            //object obj = i;///////////boxing(value type--->reference type)///////////////not necessary don't do it
            //int j =(int) obj;//////////////unboxing---->reference type to value type)
            //int[] arr = {1,2,3,4,5,6,7};
            //object[] ob = { 1, true, "abc" };
            //for(int index=0; index<arr.Length; index++)
            //{
            //    int abc = arr[index];
                
            //}
            //for (int index = 0; index < ob.Length; index++)
            //{ 
            //    object ab = ob[index];///we wont do it
            //}
            GenericClass<int> instance =new GenericClass<int>();
            instance.Add(1);
            GenericClass<string> instance2 = new GenericClass<string>();
            instance2.Add("name");
        }
    }
}