using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Utilities;

namespace LeetCode.Tests;
public class RemoveElements203Test
{
    [Fact]
    public void TestRemoveElements()
    {
        var result = new RemoveElements203().RemoveElements(ListHelper.CreateList([1, 2, 6, 3, 4, 5, 6]), 6);

        Assert.True(ListHelper.AreEqual(result, ListHelper.CreateList([1, 2, 3, 4, 5])));
    }
}
