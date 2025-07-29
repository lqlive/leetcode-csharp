using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class CountMaxOrSubsets2044Test
{

    [Fact]
    public void TestCountMaxOrSubsets()
    {
        int[] nums = { 3, 1 };
        var result = new CountMaxOrSubsets2044().CountMaxOrSubsets(nums);
        Assert.Equal(2, result);
    }
}
