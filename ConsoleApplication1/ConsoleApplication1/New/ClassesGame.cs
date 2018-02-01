using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class ClassesGame
    {
        public static void ShowTheDiffirent()
        {

            //B obj1 = new A();
            //obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
            

            C obj4 = new C();
            obj4.Foo();
            //C obj5 = new A();
            
            A obj6 = new C();
            obj6.Foo();
            B obj7 = new D();
            obj7.Foo();
             
            //C obj = new B;
        }
    }
    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class A");
        }
    }
    class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("Class B");
        }
    }
    class C : A
    {
        public new void Foo()
        {
            Console.WriteLine("Class C");
        }
    }

    class D : B
    {
        public new void Foo()
        {
            Console.WriteLine("Class D");
        }
    }
}
