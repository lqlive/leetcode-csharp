using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindJudge997Test
{
    [Fact]
    public void FindJudge()
    {
        var result = new FindJudge997().FindJudge(2,[[1, 2]]);

        Assert.Equal(2, result);
    }
}
