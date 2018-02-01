using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class TestDel1l18l2018
    {
        delegate void SetM(int i);

         static SetM setM;

        public object TT = setM;
        private static void Q2(int i)
        {
            Console.WriteLine(i*i);
        }

        private static void Q3(int i)
        {
            Console.WriteLine(i*i*i);
        }

        public static void ShowQ(int i)
        {
            setM = Q2;
            setM += Q3;

            setM(i);
        }

    }
}
