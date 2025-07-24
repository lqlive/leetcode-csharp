using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class CountPairs2176Test
{
    [Fact]
    public void TestCountPairs()
    {
        var result = new CountPairs2176().CountPairs([3, 1, 2, 2, 2, 1, 3],2);

        Assert.Equal(4, result);
    }
}
