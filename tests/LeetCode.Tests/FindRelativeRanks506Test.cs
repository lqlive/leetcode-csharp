using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindRelativeRanks506Test
{
    [Fact]
    public void TestFindRelativeRanks()
    {
        var result = new FindRelativeRanks506().FindRelativeRanks([5, 4, 3, 2, 1]);

        Assert.Equal(["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"], result);
    }
}
