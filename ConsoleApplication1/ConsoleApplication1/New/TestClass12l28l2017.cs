using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class TestClass12l28l2017
    {
        //use struct and class
        ForReferenceAndValueTypes frant1 = new ForReferenceAndValueTypes();
        ForReferenceAndValueTypes frant2 = new ForReferenceAndValueTypes();
        ThisIsStructForTest struct1 = new ThisIsStructForTest();
        ThisIsStructForTest struct2 = new ThisIsStructForTest();

        public void PlayMethod()
        {
            //class
            frant1.x = 10;
            frant1.z = 11;
            frant1.obj = frant1.x;
            frant2 = frant1;
            Console.WriteLine("Classes");
            Console.WriteLine($"fr1, x ={frant1.x}, z = {frant1.z}, obj={frant1.obj}");
            Console.WriteLine($"fr2, x ={frant2.x}, z = {frant2.z}, obj={frant2.obj}");
            frant2.x = 11;
            frant2.z = 15;
            frant2.obj = frant2.z;
            Console.WriteLine("Changes");
            Console.WriteLine($"fr1, x ={frant1.x}, z = {frant1.z}, obj={frant1.obj}");
            Console.WriteLine($"fr2, x ={frant2.x}, z = {frant2.z}, obj={frant2.obj}");
            

            //struct
            struct1.x = 6;
            struct1.z = 7;
            struct1.obj = struct1.x;
            struct2 = struct1;
            Console.WriteLine("Struct");
            Console.WriteLine($"st1, x ={struct1.x}, z = {struct1.z}, obj={struct1.obj}");
            Console.WriteLine($"st2, x ={struct2.x}, z = {struct2.z}, obj={struct2.obj}");
            struct2.x = 11;
            struct2.z = 15;
            struct2.obj = frant2.z;
            Console.WriteLine("Changes");
            Console.WriteLine($"st1, x ={struct1.x}, z = {struct1.z}, obj={struct1.obj}");
            Console.WriteLine($"st2, x ={struct2.x}, z = {struct2.z}, obj={struct2.obj}");

            //struct and class
            //struct1 = frant1;//error
            //frant1 = struct1; // error

            struct1.frav = frant1;
            struct2.frav = struct1.frav;
            Console.WriteLine("Struct and class");
            Console.WriteLine($"fr1, x ={frant1.x}, z = {frant1.z}, obj={frant1.obj}");
            Console.WriteLine($"st1, x ={struct1.frav.x}, z = {struct1.frav.z}, obj={struct1.frav.obj}");
            Console.WriteLine($"st2, x ={struct2.frav.x}, z = {struct2.frav.z}, obj={struct2.frav.obj}");
            Console.WriteLine("Changes");
            struct2.frav.x = 6;
           
            ;

            Console.WriteLine($"fr1, x ={frant1.x}, z = {frant1.z}, obj={frant1.obj}");
            Console.WriteLine($"st1, x ={struct1.frav.x}, z = {struct1.frav.z}, obj={struct1.frav.obj}");
            Console.WriteLine($"st2, x ={struct2.frav.x}, z = {struct2.frav.z}, obj={struct2.frav.obj}");
        }


    }
}
