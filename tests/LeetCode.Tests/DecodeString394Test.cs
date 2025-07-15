using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Tests;
public class DecodeString394Test
{

    [Fact]
    public void TestDecodeString()
    {
        var result = new DecodeString394().DecodeString("3[a]2[bc]");
        Assert.Equal("aaabcbc", result);
    }
}
