using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class IsValid3136
{
    public bool IsValid(string word)
    {
        if (word.Length < 3)
        {
            return false;
        }

        bool hasVowel = false;
        bool hasConsonant = false;
        foreach (var c in word)
        {
            if (char.IsLetter(c))
            {
                var ch = char.ToLower(c);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    hasVowel = true;
                }
                else
                {
                    hasConsonant = true;
                }
            }
            else if (!char.IsDigit(c))
            {
                return false;
            }

        }
        return hasVowel && hasConsonant;
    }
}