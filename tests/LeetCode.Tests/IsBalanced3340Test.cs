using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class IsBalanced3340Test
{
    [Fact]

    public void TestIsBalanced()
    {
        var result = new IsBalanced3340().IsBalanced("1234");

        Assert.False(result);
    }
}
