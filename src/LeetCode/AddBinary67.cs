using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class AddBinary67
{
    public string AddBinary(string a, string b)
    {
        var result = new List<char>();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';

            // 添加到末尾，最后反转
            result.Add((char)('0' + sum % 2));
            carry = sum / 2;
        }

        // 反转并转换为字符串
        result.Reverse();
        return new string(result.ToArray());
    }
}
