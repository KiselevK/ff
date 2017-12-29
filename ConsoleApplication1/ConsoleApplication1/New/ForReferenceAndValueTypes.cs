using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class ForReferenceAndValueTypes
    {
        public int x;
        public int z;
        public object obj;
         

    }

    struct ThisIsStructForTest
    {
        public int x;
        public int z;
        public object obj;

        public ForReferenceAndValueTypes frav;
    }

}
