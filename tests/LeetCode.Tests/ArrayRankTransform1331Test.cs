using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Tests;
public class ArrayRankTransform1331Test
{
    [Fact]
    public void TestArrayRankTransform()
    {
        var result = new ArrayRankTransform1331().ArrayRankTransform([40, 10, 20, 30]);
        Assert.Equal([4, 1, 2, 3], result);
    }
}
