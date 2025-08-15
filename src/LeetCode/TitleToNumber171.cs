using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class TitleToNumber171
{
    public int TitleToNumber(string columnTitle)
    {
        var number = 0;
        var multiple = 1;
        for (var i = columnTitle.Length - 1; i >= 0; i--)
        {
            var k = columnTitle[i] - 'A' + 1;
            number += k * multiple;
            multiple *= 26;
        }
        return number;
    }
}
