using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindLucky1394Test
{
    [Fact]
    public void TestFindLucky()
    {
        var result = new FindLucky1394().FindLucky([1, 2, 2, 3, 3, 3]);

        Assert.Equal(3, result);
    }
}
