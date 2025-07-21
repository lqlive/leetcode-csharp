using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class MakeFancyString1957Test
{
    [Fact]
    public void MakeFancyString()
    {
        var result = new MakeFancyString1957().MakeFancyString("leeetcode");

        Assert.Equal("leetcode", result);
    }
}
