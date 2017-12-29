using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void ShowCube(int i);
    class Base
    {
        
        private static int Square(int x) => x * x;
        private int RedirecterMethod( int i)
        {
            var fd = new ForDelegate();
            return ForDelegate.TransBack(i, Square);
        }

        public void WriteMethodFromBase()
        {
            Console.WriteLine("/n++++++++++++++++++++++/n");
            Console.WriteLine("*Use delegate*");
            Console.WriteLine("Input 3, Output {0}",RedirecterMethod(3));
        }

        private static void X2(int i)
        {
            Console.WriteLine("X2="+i*i);
        }

        private static void X3(int i)
        {
            Console.WriteLine("x3="+i*i*i);
        }

        public  void ShowM(int i)
        {
            Console.WriteLine("/n++++++++++++++++++++++/n");
            Console.WriteLine("*Use two methods*");
            ShowCube sc = X2;
            sc += X3;

            sc(i);
        }
    }
    }
