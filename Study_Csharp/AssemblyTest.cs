using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public class AssemblyTest
    {
       public  List<Type> LinqReturnTypes ()
        {
            List<Type> types = (AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(t => t.GetTypes())
                .Where(t => t.IsClass && t.Assembly == this.GetType().Assembly)).ToList<Type>();

            return types;
        }
    }
}
