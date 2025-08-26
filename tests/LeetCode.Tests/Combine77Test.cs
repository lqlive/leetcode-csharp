using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class Combine77Test
{
    [Fact]
    public void TestCombine()
    {
        var result = new Combine77().Combine(1, 1);

        Assert.Single(result);
    }
}
