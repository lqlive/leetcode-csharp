using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Tests;
public class DistributeCandies575Test
{
    [Fact]
    public void TestDistributeCandies()
    {
        var result = new DistributeCandies575().DistributeCandies([1, 1, 2, 2, 3, 3]);
        Assert.Equal(3, result);
    }
}
