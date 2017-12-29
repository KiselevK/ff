using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JustWhile
    {
        public void DoIt(int i)
        {
            while (i<25)
            {
                if(i == 10)break;
                i++;
                Console.Write(i+" ");
            }
        }
    }
}
