﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FibonacciDP
{
    public int Fibonacci(int n)
    {
        if (n <= 1) return n;

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <=n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];

    }
}
