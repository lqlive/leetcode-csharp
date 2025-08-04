using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class LongestPalindrome409
{
    public int LongestPalindrome(string s)
    {
        var count = new int[128];
        foreach (char c in s)
        {
            count[c]++;
        }
        int pairs = 0;
        int oddCount = 0;
        for (int i = 0; i < count.Length; i++)
        {
            pairs += count[i] / 2;
            oddCount += count[i] % 2;
        }
        return pairs * 2 + (oddCount > 0 ? 1 : 0);
    }
}