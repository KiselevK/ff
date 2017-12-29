using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate int Trans(int x);
    class ForDelegate
    {
       
        

        public static int TransBack(int i, Trans t)
        {
            return t(i);
        }
    }
}
