using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int a = rand.Next(0, 10);
            int b;
            b = 4;

            var anton = new Anton();
            Console.WriteLine(a);
            //тернарный оператор
            int x = (a==b) ? z() : f(a);
            Console.WriteLine(x);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            //статика
            anton.M2(3);
            anton.Talk();

            Console.WriteLine(StaticClass.A);
            StaticClass.Method(5);
            Console.WriteLine(StaticClass.A);

            //анонимный тип
            var v = new { Name = "Dude", d = 1 };
            Console.WriteLine("Name =" + v.Name+ " D=" + v.d);
            //вывод ссылки на обьект
            Console.WriteLine(anton);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //nullable 
            int? nul = null;
            int bi = nul ?? 5;
            Console.WriteLine(bi);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //ref//out

            int fr=4;
            StaticClass.MetForRef(ref fr);
            Console.WriteLine("fr = "+fr+" i = " + StaticClass.I);

            int fo;
            StaticClass.MetForOut(out fo);
            Console.WriteLine("fo = " + fo + " i = " + StaticClass.I);


            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //boxing and unboxing
            int box = 123;
            object forBox = box;
            Console.WriteLine("object = " + forBox);
            int unBox = (int)forBox;
            Console.WriteLine("unbox = " + unBox);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //is / as
            Console.WriteLine("Is");
            TestIsO(bi);
            var testIs = new ForIs();
            TestIsO(testIs);

            Console.WriteLine("As");
            Base bas = testIs as Base;
            Console.WriteLine(bas);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Array
            var MyArr = new ArraysClass();
            MyArr.ShowArray1();

            MyArr.ShowObjArray();

            MyArr.ShowArr2();

            Console.Read();
        }

        static void TestIsO(object o)
        {
            if (o is ForIs)
            {
                Console.WriteLine("o is ForIs");

            }
            else { Console.WriteLine("Nope"); }
        }

        static int f(int c)
        {
            if (c >= 5)
            {
               c=c<<2;
         
            }
            
           return c;
        }

        static int z()
        {
            return 3;
        }
    }

   







}
