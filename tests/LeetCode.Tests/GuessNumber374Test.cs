using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class GuessNumber374Test
{
    [Fact]
    public void TestGuessNumber3()
    {
        var result = new GuessNumber374().GuessNumber(1);
        
        Assert.Equal(1, result);
    }
}
