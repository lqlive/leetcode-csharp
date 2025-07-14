using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Tests;
public class GetDecimalValue1290Test
{
    [Fact]
    public void TestGetDecimalValue()
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(0);
        head.next.next = new ListNode(1);

        var result = new GetDecimalValue1290().GetDecimalValue(head);

        Assert.Equal(5, result);
    }
}
