using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class IsValid3136Test
{
    [Fact]
    public void TestIsValid()
    {
        var result = new IsValid3136().IsValid("234Adas");

        Assert.True(result);
    }
}
