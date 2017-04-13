using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fish:Animal
    {
        public override string ShowData()
        {
            return "It's fish\n"+"Name "+ name+ "\nSize "+ ShowSize ;
        }
    }
}
