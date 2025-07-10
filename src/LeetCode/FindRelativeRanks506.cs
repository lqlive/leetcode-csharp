using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FindRelativeRanks506
{
    public string[] FindRelativeRanks(int[] score)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < score.Length; i++)
        {
            map.Add(score[i], i);
        }

        Array.Sort(score, (x, y) => y.CompareTo(x));

        var result = new string[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            var index = map[score[i]];

            if (i == 0)
            {
                result[index] = "Gold Medal";
            }
            else if (i == 1)
            {
                result[index] = "Silver Medal";
            }
            else if (i == 2)
            {
                result[index] = "Bronze Medal";
            }
            else
            {
                result[index] = $"{i + 1}";
            }
        }
        return result;
    }
}