using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;
using LeetCode.Utilities;

namespace LeetCode.Tests;
public class DeleteDuplicates83Test
{
    [Fact]
    public void TestDeleteDuplicates()
    {
        ListNode head = ListHelper.CreateList(new int[] { 1, 1, 2 });
        var result = new DeleteDuplicates83().DeleteDuplicates(head);
        var expected = ListHelper.CreateList(new int[] { 1, 2 });
 
        Assert.True(ListHelper.AreEqual(expected, result));
    }
}