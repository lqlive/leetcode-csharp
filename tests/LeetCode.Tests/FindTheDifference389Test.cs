using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindTheDifference389Test
{
    [Fact]
    public void TestFindTheDifference()
    {

        var result = new FindTheDifference389().FindTheDifference("aabcd", "aabcde");

        Assert.Equal('e', result);
    }
}
