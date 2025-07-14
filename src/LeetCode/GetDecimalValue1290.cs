using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LeetCode.Common;

namespace LeetCode;
public class GetDecimalValue1290
{
    public int GetDecimalValue(ListNode head)
    {
        var values = new StringBuilder();

        while (head != null)
        {
            values.Append(head.val);
            head = head.next;
        }

        return Convert.ToInt32(values.ToString(), 2);
    }
}