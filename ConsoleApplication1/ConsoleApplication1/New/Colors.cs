using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class Colors
    {
    

       

        public void Green(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mess);
            Console.ResetColor();
        }

        public void Red(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mess);
            Console.ResetColor();
        }

        public void Magenta(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(mess);
            Console.ResetColor();
        }
        public void Yellow(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mess);
            Console.ResetColor();
        }

       
    }
}
