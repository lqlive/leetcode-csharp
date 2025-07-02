using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class LongestConsecutive128
{
    public int LongestConsecutive(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (var num in nums)
        {
            hashSet.Add(num);
        }

        var longestStreak = 0;

        foreach (var item in hashSet)
        {
            if (!hashSet.Contains(item - 1))
            {
                var currentNumber = item;
                var currentStreak = 1;

                while (hashSet.Contains(currentNumber + 1))
                {
                    currentNumber += 1;
                    currentStreak += 1;
                }
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;
    }
}