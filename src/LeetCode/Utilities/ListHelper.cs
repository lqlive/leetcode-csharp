using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode.Utilities;
public static class ListHelper
{
    public static ListNode CreateList(int[] values)
    {
        if (values.Length == 0) return null;

        ListNode head = new ListNode(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }
    public static bool AreEqual(ListNode list1, ListNode list2)
    {
        while (list1 != null && list2 != null)
        {
            if (list1.val != list2.val)
            {
                return false;
            }
            list1 = list1.next;
            list2 = list2.next;
        }

        return list1 == null && list2 == null;
    }
}
