using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("method1 BaseClass");
        }
    }

    public class DervicedClass :BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("method1 DervicedClass");
        }
    }

}
/*
 *    BaseClass BClassD = new DervicedClass();
            DervicedClass DClassD = new DervicedClass();

            BClassD.Method1(); 
            DClassD.Method1(); 
*/