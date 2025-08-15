using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class ThirdMax414
{
    public int ThirdMax(int[] nums)
    {
        var set = new SortedSet<int>();
        foreach (var num in nums)
        {
            set.Add(num);
            if (set.Count>3)
            {
                set.Remove(set.Min);
            }
        }
        return set.Count == 3 ? set.Min : set.Max;
    }
}
