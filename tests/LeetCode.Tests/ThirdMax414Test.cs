using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class ThirdMax414Test
{
    [Fact]
    public void TestThiredMax()
    {
        var result = new ThirdMax414().ThirdMax([2, 2, 3, 1]);

        Assert.Equal(1, result);
    }
}
