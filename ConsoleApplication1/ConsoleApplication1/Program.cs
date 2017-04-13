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
            var a = rand.Next(0, 10);
            int b;
            b = 4;

            var anton = new Anton();
            Console.WriteLine(a);
            //тернарный оператор
            int x = (a==b) ? Z() : F(a);
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
            var box = 123;
            object forBox = box;
            Console.WriteLine("object = " + forBox);
            var unBox = (int)forBox;
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
            var myArr = new ArraysClass();
            myArr.ShowArray1();

            myArr.ShowObjArray();

            myArr.ShowArr2();

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            //classes and interfaces
            var dog1 = new Dog();
            var dog2 = new Dog();
            var animal = new Animal();
            var fish = new Fish();

                dog1.SetData("Bobby", 11);
                dog2.SetData("Bill", 100);
                Console.WriteLine("Dog1 = " + dog1.ShowData());
                Console.WriteLine("Dog2 = " + dog2.ShowData());
                animal.SetData("deff", 0);
                Console.WriteLine("animal = " + animal.ShowData());
                animal = dog2;
                Console.WriteLine("animal = " + animal.ShowData());
                dog1 = (Dog) animal;
                Console.WriteLine("Dog1 = " + dog1.ShowData());
                Console.WriteLine("Dog2 = " + dog2);
                fish.SetData("Bo", 2);
                Console.WriteLine(fish.ShowData());
           
            
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            //Abstaract
            var man1 = new Man();
            var man2 = new Man("Don");
            var man3 = new Man(age:10, name:"Vonka");
            Console.WriteLine(man1.ShowData());
            Console.WriteLine(man2.ShowData());
            Console.WriteLine(man3.ShowData());


            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            //do while
            var dow1 = new DoWhile();
            var dow2 = new DoWhile();

            var do1 = new JustWhile();
            var do2 = new JustWhile();

            Console.WriteLine("DoIt 0");
            dow1.DoIt(0);
            Console.WriteLine("\nDoIt 10");
            dow2.DoIt(10);
            Console.WriteLine("\nDoIt 0");
            do1.DoIt(0);
            Console.WriteLine("\nDoIt 15");
            do2.DoIt(15);
            Console.WriteLine("\n");

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

        static int F(int c)
        {
            if (c >= 5)
            {
               c=c<<2;
         
            }
            
           return c;
        }

        static int Z()
        {
            return 3;
        }
    }

   







}
