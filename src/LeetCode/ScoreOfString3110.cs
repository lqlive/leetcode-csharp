using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class ScoreOfString3110
{
    public int ScoreOfString(string s)
    {
        var score = 0;
        for (int i = 0; i < s.Length-1; i++)
        {
            score += Math.Abs(s[i] - s[i + 1]);
        }
        return score;
    }
}
