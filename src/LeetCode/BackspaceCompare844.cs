using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class BackspaceCompare844
{
    public bool BackspaceCompare(string s, string t)
    {
        return Build(s).Equals(Build(t));
    }
    private string Build(string s)
    {
        var result = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '#')
            {
                result.Append(s[i]);
            }
            else
            {
                if (result.Length>0)
                {
                    result.Remove(result.Length - 1, 1);
                }
            }
        }
        return result.ToString();
    }
}
