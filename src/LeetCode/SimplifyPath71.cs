using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SimplifyPath71
{
    public string SimplifyPath(string path)
    {
        var names = path.Split('/');

        var stack = new Stack<string>();

        foreach (var name in names)
        {
            if (name.Equals(".."))
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (name.Length > 0 && !".".Equals(name))
            {
                stack.Push(name);
            }
        }

        if (stack.Count == 0)
        {
            return "/";
        }

        var result = new StringBuilder();
        foreach (var item in stack.Reverse())
        {
            result.Append("/");
            result.Append(item);
        }

        return result.ToString();
    }
}
