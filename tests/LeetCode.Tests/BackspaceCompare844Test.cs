using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class BackspaceCompare844Test
{
    [Fact]
    public void TestBackspaceCompare()
    {
        var result = new BackspaceCompare844().BackspaceCompare("ab#c", "ad#c");
        Assert.True(result);
    }
}
