using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class IsValid20Test
{
    [Fact]
    public void TestIsValid()
    {
        var result = new IsValid20().IsValid("()[]{}");

        Assert.True(result);
    }
}
