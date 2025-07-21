using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Common;

namespace LeetCode;
public class DeleteDuplicates83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
        {
            return head;
        }
        ListNode current = head;

        while (current.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        return head;
    }
}
