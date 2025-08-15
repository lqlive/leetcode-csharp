using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class IsPowerOfThree326Test
{
    [Fact]
    public void TestIsPowerOfThree()
    {
        var result = new IsPowerOfThree326().IsPowerOfThree(27);
        Assert.True(result);
    }
}
