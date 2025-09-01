using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FirstBadVersion278Test
{
    [Fact]
    public void TestFirstBadVersion()
    {
        var result = new FirstBadVersion278().FirstBadVersion(2);

        Assert.Equal(1, result);
    }
}
