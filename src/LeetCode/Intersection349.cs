using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class Intersection349
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var keys = new Dictionary<int, int>();

        foreach (var num in nums1)
        {
            if (!keys.ContainsKey(num))
            {
                keys.Add(num, num);
            }
        }

        foreach (var num in nums2)
        {
            if (keys.ContainsKey(num))
            {
                result.Add(num);
            }
        }
        return result.Distinct().ToArray();
    }
}