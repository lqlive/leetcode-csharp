using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindDisappearedNumbers448Test
{
    [Fact]
    public void TestFindDisappearedNumbers()
    {
        var result = new FindDisappearedNumbers448().FindDisappearedNumbers([1, 1]);
        Assert.Equal([2], [2]);
    }
}
