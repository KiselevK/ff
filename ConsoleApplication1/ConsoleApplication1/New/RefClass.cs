using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1.New
{
    class RefClass
    {
        public static void PlayWithRf()
        {

            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine("x= "+x); // 5
            xRef = 125;
            Console.WriteLine("x= "+x); // 125
            x = 66;
            Console.WriteLine("xRef(x=66) = "+xRef); //66


        }
    }
}

