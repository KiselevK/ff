using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dog:Animal, IDescription
    {
        
    
    

        public void SetData(string n, int s)
        {
            GetName(n);
            SetSize(s);
        }

        public string ShowData() => "Name is " + name + "\nSize is" + ShowSize;
    }
}
