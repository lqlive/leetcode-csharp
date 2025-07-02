using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class ContainsDuplicate217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new Dictionary<int,int>();

        foreach(int num in nums)
        {
            if (!hashSet.ContainsKey(num))
            {
                hashSet.Add(num, 1);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
