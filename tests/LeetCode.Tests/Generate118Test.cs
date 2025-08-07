using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class Generate118Test
{
    [Fact]
    public void TestGenerate()
    {
        var result = new Generate118().Generate(1);

        Assert.Equal([[1]], result);
    }
}
