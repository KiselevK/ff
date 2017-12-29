using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class Tuples
    {

        public static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;
        }

        private static (string name, int ?age) SelectPerson(string HowLooksLike)
        {

            if (HowLooksLike == "Old")
                return ("Piter", 61);
            else if (HowLooksLike == "Young")
                return ("Lora", 17);
            else
            {
                return (null,null);
            }
        }
        public static void ShowPerson()
        {

            
            var datatrans = SelectPerson("Young");
            Console.WriteLine($"Name is {datatrans.name}, age is {datatrans.age}");
            datatrans = Tuples.SelectPerson("Old");
            Console.WriteLine($"Name is {datatrans.name}, age is {datatrans.age}");
            datatrans = Tuples.SelectPerson("asdas");
            Console.WriteLine(datatrans);
        }

     

    }
}
