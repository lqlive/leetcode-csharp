using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class FindWords500
{
    public string[] FindWords(string[] words)
    {
        var rows = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };

        var result = new List<string>();
        foreach (var word in words)
        {
            var lowerWord = word.ToLower();

            foreach (var row in rows)
            {
                if (lowerWord.All(x => row.Contains(x)))
                {
                    result.Add(word);
                    break;
                }
            }
        }
        return result.ToArray();
    }
}
