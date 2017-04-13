using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Man:Person
    {

        public Man()
        {
            Name = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Age = 21;
        }

        public Man(string name, int age = 20 )
        {
            Name = name;
            Age = age;
        }

        public override string ShowData()
        {
            return Name + "\n" + Age;
        }


        
    }
}
