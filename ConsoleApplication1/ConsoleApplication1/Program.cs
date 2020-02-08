using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using  ConsoleApplication1.New;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;




            Console.WriteLine("Test");
            Console.WriteLine("new");






            //my list class
            // WorkWithNumbers.Show();

            //Collections 
            // TestCollections.ShowTestColection();
            //CollectClass.ShowQueu();
            // CollectClass.ShowStack();
            //CollectClass.ShowDictionary();



            //lambda
            Lambda.ShowLambdas();

            //events
            UseEvent();

            //Delegates //test1.24.2018
            //SetColor();
            // TestDel1l18l2018.ShowQ(11);

            //int? i = null;
            //Console.WriteLine(i);


            //Generic //Test 1.11.2018
            //AccOperation op = new AccOperation();
            //op.Op();


            //My sort methodы //test 1.5.2018
            //foreach (var ar in MySortClass.MysSortMethod())
            //{
            //    Console.WriteLine(ar);
            //}
            // MySortClass.MySortMethod();


            //link to abstract class //test 1.5.2018
            //ItsAbstractClass abs = new ItsAbstractClass(); //error 

            //test 12.29.2017 the different override, virtual, new   
            //ClassesGame.ShowTheDiffirent();
            //A a = new D();
            //Console.WriteLine(a);
            //a.Foo();

            //test 12.28.2017 use links
            //TestClass12l28l2017 test1 = new TestClass12l28l2017();
            //test1.PlayMethod();

            //test 12.27.2017 used ref
            // RefClass.PlayWithRf();

            //test 12.26.2017 used Tuple 
            // Console.WriteLine(Tuples.GetValues());
            //Tuples.ShowPerson(); //added test 12/27/2017

            //test 12.26.2017
            //Sort Array method
            // SortClass.SortArrayM();

            //new  test 
            //use params
            //UseParams.Addition(1, 2, 3, 4, 5);

            //int[] array = new int[] { 1, 2, 3, 4 };
            //UseParams.AdditionMas(array, 2);


            //old link to old test tasks
            //basOld.ShowAll();
            //bas.WriteMethodFromBase(); //call method with delegate
            //bas.ShowM(5);



            Console.Read();
        }


        

        static void SetColor()
        {
            ChangeColor colorChanger = new ChangeColor();
            Colors colors = new Colors();
           

            colorChanger.AddColor(colors.Green);
            colorChanger.AddColor(colors.Magenta);
            colorChanger.AddColor(colors.Red);
            colorChanger.AddColor(colors.Yellow);
            

            colorChanger.colorDel("Hello");
            colorChanger.DeleteColor(colors.Magenta);
            colorChanger.colorDel("Hello");
            Console.ReadLine();
        }

        static void UseEvent()
        {
            ClassCounter Counter = new ClassCounter();
            Handler1 Handler1 = new Handler1();
            Handler2 Handler2 = new Handler2();

            Counter.onCount += Handler1.Message;
            Counter.onCount += Handler2.Message;

            //Запустили счетчик
            Counter.Counter();
        }
    }

}

