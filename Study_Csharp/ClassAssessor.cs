using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public class ClassAssessor
    {
        public static ClassAssessor Create()
        {
            return new ClassAssessor();
        }

        protected ClassAssessor() { }

    }

    public class InheritClass : ClassAssessor
    {
        public InheritClass() { }
        public ClassAssessor cl = ClassAssessor.Create();
    }
}
