using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class IsPowerOfFour342
{
    public bool IsPowerOfFour(int n)
    {
        while (n != 0 && n % 4 == 0)
        {
            n /= 4;
        }
        return n == 1;
    }
}
