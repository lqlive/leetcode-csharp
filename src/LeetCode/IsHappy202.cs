using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class IsHappy202
{
    public bool IsHappy(int n)
    {
        var cycleMembers = new HashSet<int>()
        {
            4, 16, 37, 58, 89, 145, 42, 20
        };
        
        while (n != 1 && !cycleMembers.Contains(n))
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            n = sum;
        }
       
       return n == 1;

    }
}
