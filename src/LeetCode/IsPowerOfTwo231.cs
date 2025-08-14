using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPowerOfTwo231
    {
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & -n) == n;
        }
    }
}
