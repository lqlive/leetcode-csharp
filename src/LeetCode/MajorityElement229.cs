using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class MajorityElement229
{
    public IList<int> MajorityElement(int[] nums)
    {
        var keys = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            if (!keys.ContainsKey(item))
            {
                keys.Add(item, 1);
            }
            else
            {
                keys[item]++;
            }
        }
        var ans = new List<int>();

        foreach (var item in keys)
        {
            if (item.Value > nums.Length / 3)
            {
                ans.Add(item.Key);
            }
        }
        return ans;
    }
}