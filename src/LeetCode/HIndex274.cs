using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class HIndex274
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);

        var h = 0; var n = citations.Length - 1;
        while (n >= 0 && citations[n] > h)
        {
            h++;
            n--;
        }
        return h;
    }
}
