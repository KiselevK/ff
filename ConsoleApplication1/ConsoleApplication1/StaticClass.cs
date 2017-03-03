using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class StaticClass
    {
        private static int a;
        private static int i;

        public static int I
        {
            get { return i; }
        }

        public static int A
        {
            get { return a; }
        }

        public static void Method(int b)
        {
            a += b;
        }
        public static void MetForRef(ref int ii)
        {
            i = ii * ii;
            ii += i;
            i = (int)(i - (ii * 0.5));
        }
        public static void MetForOut(out int io)
        {

            io = i;
        }
    }
}
