using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class CountDays3169
{
    public int CountDays(int days, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        var merged = new List<int[]>();

        foreach (var meeting in meetings)
        {
            if (merged.Count == 0 || merged.Last()[1] < meeting[0])
            {
                merged.Add(new int[] { meeting[0], meeting[1] });
            }
            else
            {
                merged.Last()[1] = Math.Max(merged.Last()[1], meeting[1]);
            }
        }

        var busyDays = 0;
        foreach (var interval in merged)
        {
            var start = Math.Max(1, interval[0]);
            var end = Math.Min(days, interval[1]);
            if (start <= end)
            {
                busyDays += end - start + 1;
            }
        }
        return days - busyDays;
    }
}