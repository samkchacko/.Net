using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertanceDemo
{
    internal class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            throw new NotImplementedException();
        }
        public override void method2()
        {
            base.method2();
        }
    }
}
