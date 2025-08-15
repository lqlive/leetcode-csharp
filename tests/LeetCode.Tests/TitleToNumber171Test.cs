using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class TitleToNumber171Test
{
    [Fact]
    public void TestTitleToNumber()
    {
        var result = new TitleToNumber171().TitleToNumber("A");

        Assert.Equal(1, result);
    }
}
