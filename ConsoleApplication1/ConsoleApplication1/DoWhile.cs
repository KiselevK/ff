using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DoWhile
    {

        public void DoIt(int i)
        {
            do
            {
                i++;
                Console.Write(i+" ");
            } while (i<10);
        }

    }
}
