using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Tests;
public class FirstUniqChar387Test
{
    [Fact]
    public void TestFirstUniqChar387()
    {
        var result = new FirstUniqChar387().FirstUniqChar("loveleetcode");

        Assert.Equal(2, result);
    }
}
