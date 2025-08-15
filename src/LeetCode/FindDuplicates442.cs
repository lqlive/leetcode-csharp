using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FindDuplicates442
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var n = nums.Length;
        var ans = new List<int>();

        for (int i = 0; i < n; i++)
        {
            var x = Math.Abs(nums[i]);
            if (nums[x - 1] > 0)
            {
                nums[x - 1] = -nums[x - 1];
            }
            else
            {
                ans.Add(x);
            }
        }
        return ans;
    }
}
