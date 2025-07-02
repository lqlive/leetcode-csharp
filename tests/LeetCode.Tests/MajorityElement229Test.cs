using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class MajorityElement229Test
{
    [Fact]
    public void TestMajorityElement()
    {
        int[] nums = new int[] { 3, 2, 3 };

        var result = new MajorityElement229().MajorityElement(nums);

        Assert.Equal([3], result);
    }
}
