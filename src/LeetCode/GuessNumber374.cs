using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class GuessNumber374
{
    public int GuessNumber(int n)
    {
        var left = 1;
        var right = n;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (guess(mid) <= 0)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
    int guess(int n)
    {
        return n - 1;
    }
}
