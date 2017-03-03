using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArraysClass
    {

        Random rand = new Random();

        int[] MyArr = new int[5];

        object[] objectArr = {122, "hy", 'x', 123.4 };

        int[,] arr2 = new int [3,2];
        int[][] arr3;


        public void ShowArray1()
        {
            Console.WriteLine("Just MyArr before fill");

            foreach (int i in MyArr)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("Just MyArr after fill");

            for (int i=0; i<MyArr.Length; i++ )
            {
                MyArr[i] = rand.Next(1, 5) * i;
            }

            foreach (int i in MyArr)
            {
                Console.Write(i + " ");
            }
        }

        public void ShowObjArray()
        {

            Console.WriteLine("\nObject array");
            for (int i=0; i< objectArr.Length; i++)
            {
                Console.Write(objectArr[i].GetType() + " ");

            }

        }

        public void ShowArr2()
        {
            Console.WriteLine("\narr2");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr2[i, j] = (i+1) * rand.Next(1, 5);
                    Console.Write("{0} ", arr2[i, j]);
                }
            }
        }

    }
}
