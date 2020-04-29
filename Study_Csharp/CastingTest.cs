using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public static class CastingTest
    {
        public static void CastToInt()
        {
            ArrayList array1 = new ArrayList();
            int var1 = 10;
            int var2;
            array1.Add(var1);
            var2 = Convert.ToInt32(array1[0]);
            Console.WriteLine(var2);
        }
    }
}
