using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class PossibleStringCount3330Test
{
    [Fact]
    public void TestPossibleStringCount()
    {
       
        var result = new PossibleStringCount3330().PossibleStringCount("abbcccc");

        Assert.Equal(5, result);
    }
}
