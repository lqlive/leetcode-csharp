using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class ConvertToTitle168
{
    public string ConvertToTitle(int columnNumber)
    {
        var sb = new StringBuilder();

        while (columnNumber > 0)
        {
            var a0 = (columnNumber - 1) % 26 + 1;
            sb.Append((char)(a0 - 1 + 'A'));
            columnNumber = (columnNumber - a0) / 26;
        }

        var columTitle = new StringBuilder();

        for (var i = sb.Length - 1; i >= 0; i--)
        {
            columTitle.Append(sb[i]);
        }
        return columTitle.ToString();
    }
}