using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class MaximumLength3202Test
{
    [Fact]
    public void TestMaximumLength()
    {
        var result = new MaximumLength3202().MaximumLength([1, 4, 2, 3, 1, 4], 3);
        Assert.Equal(4, result);
    }
}
