using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OldTestCode
    {
        //test 1 
        //int i = 1;
        //object obj = i;
        //++i;
        //Console.WriteLine(i);
        //Console.WriteLine(obj);
        //Console.WriteLine((short) obj);

        //test 2
        //var s = new S();
        //using (s)
        //{
        //    Console.WriteLine(s.GetDispose());
        //}
        //Console.WriteLine(s.GetDispose());
        //List<Action> actions = new List<Action>();
        //for (var count = 0; count < 10; count++)
        //{

        //    actions.Add(() => Console.WriteLine(count));
        //}
        //foreach (var action in actions)
        //{
        //    action();
        //}

        //Console.ForegroundColor = ConsoleColor.Green;
        //var bas = new Base();
        //var basOld = new BasicOld();

        //int s = 260;

        //Console.WriteLine($"S = {s}");
        
            
            //test 2
        //void CheckString()
        //{
        //    var s1 = string.Format("{0}{1}", "abc", "cba");
        //    var s2 = "abc" + "cba";
        //    var s3 = "abccba";

        //    Console.WriteLine(s1 == s2);
        //    Console.WriteLine((object)s1 == (object)s2);
        //    Console.WriteLine(s2 == s3);
        //    Console.WriteLine((object)s2 == (object)s3);

        //    Console.WriteLine(s1);
        //}

       

    }

    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
}
