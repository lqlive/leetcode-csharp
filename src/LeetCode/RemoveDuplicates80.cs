using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class RemoveDuplicates80
{
    public int RemoveDuplicates(int[] nums)
    {
        var length = nums.Length;

        if (length <= 2)
        {
            return length;
        }

        var slow = 2; var fast = 2;

        while (fast < length)
        {
            if (nums[slow - 2] != nums[fast])
            {
                nums[slow] = nums[fast];
                slow++;
            }
            fast++;
        }

        return slow;
    }
}