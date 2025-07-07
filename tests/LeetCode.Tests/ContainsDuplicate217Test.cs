using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class ContainsDuplicate217Test
{
    [Fact]
    public void TestContainsDuplicate()
    {
        int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };

        var result = new ContainsDuplicate217().ContainsDuplicate(nums);

        Assert.False(result);
    }
}
