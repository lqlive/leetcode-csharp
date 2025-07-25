using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class DivideString2138
{
    public string[] DivideString(string s, int k, char fill)
    {
        var result = new List<string>();
        for (int i = 0; i < s.Length; i += k)
        {
       
            var group = s[i..Math.Min(i + k, s.Length)];

            if (group.Length < k)
            {
                group = group.PadRight(k, fill);
            }
            result.Add(group);
        }
        return result.ToArray();
    }
}