using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FibonacciDPTest
{
    [Fact]
    public void TestFibonacciDP()
    {
        var result = new FibonacciDP().Fibonacci(3);

        Assert.Equal(2,result);
    }
}
