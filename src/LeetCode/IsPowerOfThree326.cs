using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class IsPowerOfThree326
{
    public bool IsPowerOfThree(int n)
    {
        while (n != 0 && n % 3 == 0)
        {
            n /= 3;
        }
        return n == 1;
    }
}