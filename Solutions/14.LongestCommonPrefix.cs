using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string commonPrefix = "";

            if (strs != null && strs.Length != 0) {
                commonPrefix = new string (strs.First()
                .TakeWhile((c, i) => strs.All(s => i < s.Length && s[i] == c)) 
                .ToArray());
            }
            // First() Gets the first string
            // TakeWhile() iterates over all caracters until one dont coincide in all strings
            // (c, i) are lambda parameters, c is caracter from the first string and i is the index of that caracter
            // strs.All() verifies that every string s follow the conditions (i < s.Length) and (s[i] == c)

            return commonPrefix;
        }
    }
}
