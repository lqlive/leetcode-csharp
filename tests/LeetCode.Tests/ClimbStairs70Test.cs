using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class ClimbStairs70Test
{
    [Fact]
    public void TestClimbStairs()
    {
        var result = new ClimbStairs70().ClimbStairs(2);

        Assert.Equal(2, result);
    }
}
