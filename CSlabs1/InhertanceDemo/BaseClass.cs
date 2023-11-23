using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertanceDemo
{
    abstract class BaseClass
    {
        public abstract void Method1();
        public virtual void method2()
        {
            Console.WriteLine("HI");
        }
        public virtual void method3() 
        {
            Console.WriteLine("hELLO");
        }
    }
}
