using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class IsValid20
{
    public bool IsValid(string s)
    {
        var symbols = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (symbols.ContainsKey(c))
            {
                stack.Push(c);
            }

            if (symbols.ContainsValue(c))
            {
                if (!stack.Any())
                {
                    return false;
                }

                if (c != symbols[stack.Peek()])
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return !stack.Any();
    }
}
