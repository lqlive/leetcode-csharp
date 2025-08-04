using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class IsPalindrome9Test
{
    [Fact]
    public void TestIsPalindrome()
    {
        var result = new IsPalindrome9().IsPalindrome(121);

        Assert.True(result);
    }
}
