using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class SimplifyPath71Test
{
    [Fact]
    public void TestSimplifyPath()
    {
        var result = new SimplifyPath71().SimplifyPath("/home/user/Documents/../Pictures");

        Assert.Equal("/home/user/Pictures", result);
    }
}
