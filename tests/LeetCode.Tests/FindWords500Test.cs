using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class FindWords500Test
{
    [Fact]
    public void TestFindWords()
    {
        var result = new FindWords500().FindWords(["Hello", "Alaska", "Dad", "Peace"]);

        Assert.Equal(["Alaska", "Dad"], result);
    }
}
