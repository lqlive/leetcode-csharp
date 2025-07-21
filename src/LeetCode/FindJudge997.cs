using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FindJudge997
{
    public int FindJudge(int n, int[][] trust)
    {
        if (n == 1 && trust.Length == 0)
        {
            return 1;
        }

        var trustCount = new int[n + 1];

        for (int i = 0; i < trust.Length; i++)
        {
            var a = trust[i][0];
            var b = trust[i][1];

            trustCount[a]--;
            trustCount[b]++;
        }

        for (int i = 0; i < trustCount.Length; i++)
        {
            if (trustCount[i] == n - 1)
            {
                return i;
            }
        }
        return -1;
    }
}