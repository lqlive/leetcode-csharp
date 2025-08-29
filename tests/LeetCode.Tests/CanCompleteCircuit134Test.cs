using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class CanCompleteCircuit134Test
{
    [Fact]
    public void TestCanCompleteCircuit()
    {
        var result = new CanCompleteCircuit134().CanCompleteCircuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]);

        Assert.Equal(3, result);
    }
}
