using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class MaxProfit122
{
    public int MaxProfit(int[] prices)
    {
        var ans = 0;
        var n = prices.Length;
        for (int i = 1; i < n; i++)
        {
            ans += Math.Max(0, prices[i] - prices[i - 1]);
        }
        return ans;
    }
}
