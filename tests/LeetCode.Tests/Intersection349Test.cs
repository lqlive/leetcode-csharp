using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests;
public class Intersection349Test
{
    [Fact]
    public void TestIntersection()
    {
        int[] nums1 = new int[] { 1, 2, 2, 1 };
        int[] nums2 = new int[] { 2, 2 };

        var result = new Intersection349().Intersection(nums1,nums2);

        Assert.Equal([2], result);
    }
}
