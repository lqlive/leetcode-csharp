using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class HIndex274Test
{
    [Fact]
    public void TestHIndex()
    {
        int[] nums = new int[] { 3, 0, 6, 1, 5 };
        var result = new HIndex274().HIndex(nums);
        Assert.Equal(3,result);
    }
}
