using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class Lambda
    {
        delegate int XX(int x);

        delegate void X(int x);

        delegate void Mess();




        static public void ShowLambdas()
        {
            XX xx = x => x * x;

            int z = xx(6);
            Console.WriteLine(z);
            Mess mess = () => Console.WriteLine("Hello");
            Mess mess2 = () => Console.WriteLine("World");
            X xd = x => Console.WriteLine(x);

            mess();
            mess2();
            xd(6);


        }

      


    }

 }
