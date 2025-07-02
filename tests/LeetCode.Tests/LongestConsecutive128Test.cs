using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;


public class LongestConsecutive128Test
{
    [Fact]
    public void TestLongestConsecutive()
    {
        int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };

        var result = new LongestConsecutive128().LongestConsecutive(nums);

        Assert.Equal(4, result);
    }
}
