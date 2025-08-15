using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class ConvertToTitle168Test
{
    [Fact]
    public void TestConvertToTitle()
    {
        var result = new ConvertToTitle168().ConvertToTitle(1);

        Assert.Equal("A", result);
    }
}
