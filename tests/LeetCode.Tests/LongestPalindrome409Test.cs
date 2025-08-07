using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class LongestPalindrome409Test
{
    [Fact]
    public void TestLongestPalindrome()
    {
        var result = new LongestPalindrome409().LongestPalindrome("abccccdd");

        Assert.Equal(7, result);
    }
}
