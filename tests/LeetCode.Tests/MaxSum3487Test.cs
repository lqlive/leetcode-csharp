using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class MaxSum3487Test
{
    [Fact]
    public void TestMaxSum()
    {
        var result = new MaxSum3487().MaxSum([1, 2, 3, 4, 5]);
        Assert.Equal(15, result);
    }
}
