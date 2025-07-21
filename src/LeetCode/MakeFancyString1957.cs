using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class MakeFancyString1957
{
    public string MakeFancyString(string s)
    {
        var result = new StringBuilder();
        foreach (var c in s)
        {
            if (result.Length < 2 || result[result.Length - 1] != c || result[result.Length - 2] != c)
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}