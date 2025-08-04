using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class Generate118
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            var row = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0)
                {
                    row.Add(1);
                }
                else
                {
                    var value = (long)row[j - 1] * (i - j + 1) / j;
                    row.Add((int)value);
                }
            }

            result.Add(row);
        }
        return result;
    }
}