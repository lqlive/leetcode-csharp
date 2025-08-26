using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class IsHappy202Test
{
    [Fact]
    public void TestIsHappy()
    {
        var result = new IsHappy202().IsHappy(19);
        
        Assert.True(result);
    }
}
