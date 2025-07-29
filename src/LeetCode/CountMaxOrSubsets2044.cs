using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class CountMaxOrSubsets2044
{
    private int maxOr;
    private int count;
    public int CountMaxOrSubsets(int[] nums)
    {
        maxOr = 0;
        count = 0;

        foreach (var num in nums)
        {
            maxOr |= num;
        }
        Backrack(nums, 0, 0);
        return count;
    }

    private void Backrack(int[] nums, int index, int currentOr)
    {
        if (currentOr == maxOr)
        {
            count += 1 << (nums.Length - index);
            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            Backrack(nums, i + 1, currentOr | nums[i]);
        }
    }
}