using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   abstract class Person
   {
       private  string name;
      private int age;

       protected string Name {
           set { name = value; }
           get { return name.Length < 10 ? name :"Error set name" ; }

       }
        protected int Age
        {
            set { age = value; }
            get { return age <= 20 ? age : 0; }

        }

        public abstract string ShowData();

   }

}
