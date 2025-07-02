using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FindTheDifference389
{
    public char FindTheDifference(string s, string t)
    {

       var keys = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!keys.ContainsKey(c))
            {
                keys.Add(c, 1);
            }
            else
            {
                keys[c]++;
            }
        }

        foreach (var c in t)
        {
            if (!keys.ContainsKey(c) || keys[c] == 0)
            {
                return c;
            }
            keys[c]--;

        }
        return default(char);
    }
}
