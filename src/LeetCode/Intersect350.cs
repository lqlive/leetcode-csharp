using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class Intersect350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var keys = new Dictionary<int, int>();

        foreach (var num in nums1)
        {
            if (!keys.ContainsKey(num))
            {
                keys.Add(num, 1);
            }
            else
            {
                keys[num]++;
            }
        }

        foreach (var num in nums2)
        {
            if (keys.ContainsKey(num) && keys[num] > 0)
            {
                result.Add(num);
                keys[num]--;

                if (keys[num] == 0)
                {
                    keys.Remove(num);
                }
            }
        }
        return result.ToArray();
    }
}
