using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class ShortestCompletingWord748Test
{
    [Fact]
    public void TestShortestCompletingWord()
    {
        var licensePlate = "1s3 PSt";
        var words = new string[] { "step", "steps", "stripe", "stepple" };
        var result = new ShortestCompletingWord748().ShortestCompletingWord(licensePlate, words);

        Assert.Equal("steps", result);
    }
}
