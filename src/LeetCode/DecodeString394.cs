using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class DecodeString394
{
    public string DecodeString(string s)
    {
        Stack<StringBuilder> stringStack = new Stack<StringBuilder>();
        Stack<int> countStack = new Stack<int>();

        StringBuilder current=new StringBuilder();
        int count = 0;

        foreach (var c in s)
        {
            if (char.IsDigit(c))
            {
                count = count * 10 + (c - '0');
            }
            else if (c == '[')
            {
                stringStack.Push(current);
                countStack.Push(count);
                current = new StringBuilder();
                count = 0;
            }
            else if (c == ']')
            {
                var temp = current;
                current = stringStack.Pop();
                var repeatCount = countStack.Pop();

                for (int i = 0; i < repeatCount; i++)
                {
                    current.Append(temp);
                }
            }
            else
            {
                current.Append(c);
            }
        }
        return current.ToString();
    }
}
