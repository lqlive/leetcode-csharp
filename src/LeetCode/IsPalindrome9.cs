using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class IsPalindrome9
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x < 10)
        {
            return true;
        }

        if (x % 10 == 0)
        {
            return false;
        }

        var reversed = 0;
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return x == reversed || x == reversed / 10;
    }
}
