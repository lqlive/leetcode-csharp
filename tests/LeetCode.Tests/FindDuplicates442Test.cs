using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindDuplicates442Test
{
    [Fact]
    public void TestFindDuplicates()
    {
        var result = new FindDuplicates442().FindDuplicates([4, 3, 2, 7, 8, 2, 3, 1]);

        Assert.Equal([2, 3], result);
    }
}