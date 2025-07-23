using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class MaximumUniqueSubarray1695
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        var lenght = nums.Length;
        var psum = new int[lenght + 1];
        var cnt = new Dictionary<int, int>();
        var ans = 0;
        var pre = 0;

        for (int i = 0; i < lenght; i++)
        {
            psum[i + 1] = psum[i] + nums[i];
            pre = Math.Max(pre, cnt.GetValueOrDefault(nums[i], 0));
            ans = Math.Max(ans, psum[i + 1] - psum[pre]);
            cnt[nums[i]] = i + 1;
        }
        return ans;
    }
}
