using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public static class StringExample
    {
        static public StringBuilder StringBuilderExample()
        {
            var sb = new StringBuilder();
            sb.Append("First Line");
            sb.AppendLine();
            sb.AppendLine(); //need two to create a empty line between 
            sb.Append("Second Line");

            return sb;
        }

    }
}
