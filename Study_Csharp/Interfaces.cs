using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public interface INewInterfaces
    {
        void Method1();
    }

    public class Class1 : Class2
    {
        
    }

    public class Class2 : INewInterfaces
    {
         void INewInterfaces.Method1()
        {
            throw new NotImplementedException();
        }
        public void Method1()
        {
            Console.WriteLine("implicit");
        }
    }
}