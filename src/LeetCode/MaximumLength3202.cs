using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class MaximumLength3202
{
    public int MaximumLength(int[] nums, int k)
    {
        var dp = new int[k, k];
        var result = 0;
        foreach (var item in nums)
        {
            var mod = item % k;
            for (int prev = 0; prev < k; prev++)
            {
                dp[prev, mod] = dp[mod, prev] +1;
                result = Math.Max(result, dp[mod, prev]);
            }
        }
        return result;
    }
}
