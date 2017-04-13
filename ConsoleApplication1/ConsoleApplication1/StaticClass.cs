using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal static class StaticClass
    {
        private static int _a;
        private static int _i;

        public static int I => _i;

        public static int A => _a;

        public static void Method(int b)
        {
            _a += b;
        }
        public static void MetForRef(ref int ii)
        {
            _i = ii * ii;
            ii += _i;
            _i = (int)(_i - (ii * 0.5));
        }
        public static void MetForOut(out int io)
        {

            io = _i;
        }
    }
}
