using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FindLucky1394
{
    public int FindLucky(int[] arr)
    {
        var counts = new Dictionary<int, int>();

        foreach (var item in arr)
        {
            counts[item] = counts.TryGetValue(item, out int count) ? count + 1 : 1;
        }

        foreach (var count in counts.OrderByDescending(x=>x.Key))
        {
            if (count.Key == count.Value)
            {
                return count.Key;
            }
        }
        return -1;
    }
}
