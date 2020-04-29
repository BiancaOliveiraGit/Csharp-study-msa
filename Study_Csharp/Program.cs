using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of Task
            // TaskExample.SimpleTask();
            // TaskExample.ContinueWithTask();
            // TaskExample.ChildWithTaskFactory();


            //example of StringBuilder
            // Console.WriteLine(StringExample.StringBuilderExample());

            // string surface = LinqExample.MatchIdForSurface(2, "SIDEB");
            // Console.WriteLine(surface);
            //Runner newtracker = new Runner();
            //newtracker.Add("HuckleBerry Fin");

            //example of delegate
            //Runner delRunner = new Runner();
            //delRunner.Add("book title 1");



            /*
             Class2 class2 = new Class2();
             Class1 class1 = new Class1();
                        
              //Both throw exception
             INewInterfaces classInterface1 = new Class1();
            // classInterface1.Method1();

            INewInterfaces classInterface2 = new Class2();
            // classInterface2.Method1();

            class2.Method1();
            class1.Method1();
            */

            /*
            InheritClass inheritedClass = new InheritClass();
           // inheritedClass.cl;
           */

            /*
            DebugTest debugTest = new DebugTest();
            debugTest.RunTestClass();
            */


            // List<string> resultRegex = RegexTest.TestIfWebSite("http://www.gmail.com");

            // CastingTest.CastToInt();

            /* AssemblyTest result = new AssemblyTest();
            var typeReturn = result.LinqReturnTypes();
            */


            /*
            XElementTest.SimpleXElement();
            XElementTest.LinqXElement();
            XElementTest.XElementChild();
            */

            BaseClass BClassD = new DervicedClass();
            DervicedClass DClassD = new DervicedClass();

            BClassD.Method1(); 
            DClassD.Method1(); 
            var r = (BaseClass)DClassD;
            r.Method1();

            Console.ReadKey();
        }
    }
}
