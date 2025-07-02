using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class Intersect350Test
{
    [Fact]
    public void TestIntersect()
    {
        int[] nums1 = new int[] { 4, 9, 5 };
        int[] nums2 = new int[] { 9, 4, 9, 8, 4 };

        var result = new Intersect350().Intersect(nums1, nums2);

        Assert.Equal([9,4], result);
    }
}
