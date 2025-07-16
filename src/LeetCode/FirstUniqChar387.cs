using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FirstUniqChar387
{
    public int FirstUniqChar(string s)
    {
        var frequency = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (frequency.ContainsKey(s[i]))
            {
                frequency[s[i]] = frequency[s[i]]+1;
            }
            else
            {
                frequency[s[i]] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (frequency[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}