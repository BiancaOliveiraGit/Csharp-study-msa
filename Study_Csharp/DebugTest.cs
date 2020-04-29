//#define DEBUG  /* This actually defines everything to be in debug mode */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Study_Csharp
{

    public class DebugTest
    {
        [Conditional("DEBUG")]
        public void LogData()
        {
            Console.WriteLine("LogDate() - LogData1");
        }

        public void RunTestClass()
        {
            this.LogData();

#if (DEBUG)
            Console.WriteLine("RunTestClass - LogData2");
#elif (RELEASE)
            Console.WriteLine("release mode");
#endif
        }
    }
}
