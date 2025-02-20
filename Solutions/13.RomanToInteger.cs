using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            for (int i = 0; i < s.Length - 1; i++)
            {
                // If the left caracter is lower than the right caracter, substracts
                if (map[s[i]] < map[s[i+1]]) result -= map[s[i]];
                // Else, it sums
                else result += map[s[i]];
            }
            
            // Sum the last caracter
            result += map[s[s.Length - 1]];

            return result;
        }
    }
}
