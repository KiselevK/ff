using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    abstract class ItsAbstractClass
    {
        public abstract string AbstractMethod();

        private void ShowAbstractMethod() => Console.WriteLine(AbstractMethod());



    }
}
