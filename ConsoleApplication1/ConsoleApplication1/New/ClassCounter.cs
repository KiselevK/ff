using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class ClassCounter
    {
        public delegate void MethodContainer();

        //Событие OnCount c типом делегата MethodContainer.
        public event MethodContainer onCount;

        public void Counter()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 75)
                {
                    onCount();
                }
            }
        }
    }
}
