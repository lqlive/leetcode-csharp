using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class CombinationSum39Test
{
    [Fact]
    public void TestCombinationSum()
    {
        var result = new CombinationSum39().CombinationSum([2, 3, 6], 7);
        Assert.Single(result);
    }
}
