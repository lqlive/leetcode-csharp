using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class MaxProfit122Test
{
    [Fact]
    public void TestMaxProfit()
    {
        var result = new MaxProfit122().MaxProfit([7, 1, 5, 3, 6, 4]);
        Assert.Equal(7, result);
    }
}
