using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class DivideString2138Test
{
    [Fact]
    public void TestDivideString()
    {
        var result = new DivideString2138().DivideString("abcdefghi",3,'x');

        Assert.Equal(["abc", "def", "ghi"], result);
    }
}
