using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class ScoreOfString3110Test
{
    [Fact]
    public void TestScoreOfString()
    {
        var result = new ScoreOfString3110().ScoreOfString("hello");

        Assert.Equal(13, result);
    }
}
