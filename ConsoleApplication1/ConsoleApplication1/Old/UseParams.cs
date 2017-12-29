using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class UseParams
    {
        // передача параметра с params
        static public void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        // передача массива
        static public void AdditionMas(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }

       
            

            
       
    }
}
