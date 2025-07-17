using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class DistributeCandies575
{
    public int DistributeCandies(int[] candyType)
    {
        var set = new HashSet<int>(candyType);
  
        return Math.Min(set.Count, candyType.Length / 2);
    }
}
