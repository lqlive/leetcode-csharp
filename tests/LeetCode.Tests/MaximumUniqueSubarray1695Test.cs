using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class MaximumUniqueSubarray1695Test
{
    [Fact]
    public void TestMaximumUniqueSubarray()
    {
        var result = new MaximumUniqueSubarray1695().MaximumUniqueSubarray([4, 2, 4, 5, 6]);
        Assert.Equal(17, result);
    }
}
