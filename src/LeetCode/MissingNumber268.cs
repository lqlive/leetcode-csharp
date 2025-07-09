using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class MissingNumber268
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }
        return n;
    }
}
