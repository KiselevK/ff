using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class MySortClass
    {
        public static int[] MysSortMethod()
        {
             int[] arr = {5, 6, 1, 4, 6, 8, 9};
            int j;
            for (int i = 0;i<arr.Length-1; i++)
            {
                j = i+1;
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i = -1;
                }
            }
            return arr;
        }

        public static void MySortMethod()
        {
            var input = new[] { 1, 9, 2, 1, 3 };

            foreach (var n in input)
                Task.Run(() =>
                {
                    Thread.Sleep(n * 100);
                    Console.WriteLine(n);
                });
        }
    }
}
