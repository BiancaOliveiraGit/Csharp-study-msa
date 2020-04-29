using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public class RegexTest
    {
        public static List<string> TestIfWebSite(string url)
        {
            const string pattern = @"http://(www\.)?([^\.]+)\.com";
           // List<string> result = new List<string>();

            MatchCollection myMatches = Regex.Matches(url, pattern);

            //throws an exception
            // List<string>  result = (List<string>)myMatches.GetEnumerator();
            foreach (Match m in (List<Match>)myMatches.GetEnumerator())
            {
                //this is how you use GetEnumerator()
            }


            //this is correct
            List<string> result = (from Match m in myMatches select m.Value).ToList<string>();
            return result;
        }
    }
}
