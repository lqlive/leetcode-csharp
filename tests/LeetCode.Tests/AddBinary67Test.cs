using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class AddBinary67Test
{
    [Fact]
    public void TestAddBinary()
    {
        var result = new AddBinary67().AddBinary("11", "1");

        Assert.Equal("100", result);

    }
}
