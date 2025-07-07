using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class RemoveDuplicates80Test
{
    [Fact]
    public void RemoveDuplicates()
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

        var result = new RemoveDuplicates80().RemoveDuplicates(nums);

        Assert.Equal(7,result);
    }
}
