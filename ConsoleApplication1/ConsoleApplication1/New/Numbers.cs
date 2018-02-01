using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class Numbers
    {
        private int[] nums= null;
       
        public Numbers(params int [] values)
        {
            int valCount = values.Length;
            nums = new int[valCount];
            for (int i = 0; i < values.Length; i++)
            {
                nums[i] = values[i];
            }

        }

        public void ShowValues()
        {
            foreach (var VARIABLE in nums)
            {
                Console.Write(VARIABLE+ " ");
            }
        }

        public void Add(int i)
        {
           
           

            int[] temp = new int[nums.Length];
           
            for (int j = 0; j < nums.Length; j++)
            {
                temp[j] = nums[j];
            }

            nums = new int[nums.Length + 1];
            for (int j = 0; j < temp.Length; j++)
            {
                nums[j] = temp[j];
            }
            nums[nums.Length - 1] = i;
            
        }

        public void Remove(int index)
        {
            int[] temp = new int[nums.Length - 1];
            for (int i = 0, j = 0; i < temp.Length; i++, j++)
            {
                if (index == i)
                {
                    j++;
                }
                
                    temp[i] = nums[j];
                
            }
             nums=new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];
            }
        }

        public int this[int index]
        {
            get
            {
                if (nums == null)
                {
                    Console.WriteLine("n");
                    return 0;
                    
                }
                return nums[index];
            }
            set { nums[index] = value; }
        }

    }

    static class WorkWithNumbers
    {
       public static void Show()
        {
            Numbers nums = new Numbers(1, 2, 3, 4);
            nums.ShowValues();
            nums.Add(5);
            Console.WriteLine();
            nums.ShowValues();

            Console.WriteLine("\n"+nums[3]);
            nums[3] = 10;
            Console.WriteLine(nums[3]);
            Console.WriteLine();
            nums.ShowValues();

            Console.WriteLine();
            nums.Remove(1);
            nums.ShowValues();
            Console.WriteLine();
            nums.Remove(3);
            nums.ShowValues();

        }
    }
}
