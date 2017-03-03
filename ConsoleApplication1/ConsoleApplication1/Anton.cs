using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Anton
    {
        private int a;

        public void M2(int d)
        { StaticClass.Method(d); }

        public void Talk()
        {
            a = StaticClass.A;
            Console.WriteLine("Static from Anton = " + a);
        }
    }
}
