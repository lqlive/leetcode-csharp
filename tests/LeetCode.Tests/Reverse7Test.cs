using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class Reverse7Test
{
    [Fact]
    public void TestReverse()
    {
        var result = new Reverse7().Reverse(-123);

        Assert.Equal(-321, result);
    }
}
