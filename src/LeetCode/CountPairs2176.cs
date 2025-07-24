using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class CountPairs2176
{
    public int CountPairs(int[] nums, int k)
    {
        var result = 0;

        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((i * j) % k == 0 && nums[i] == nums[j])
                {
                    result++;
                }
            }
        }
        return result;

    }
}
