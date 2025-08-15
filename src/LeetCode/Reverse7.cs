using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class Reverse7
{
    public int Reverse(int x)
    {
        var value = x.ToString();

        if (value[0] == '-')
        {
            var chars = value.Substring(1).ToCharArray();

            Array.Reverse(chars);

            if (int.TryParse($"-{new String(chars)}", out var result))
            {
                return result;
            }
            return 0;
        }
        {
            var chars = value.ToArray();
            Array.Reverse(chars);

            if (int.TryParse(new String(chars), out var result))
            {
                return result;
            }
            return 0;
        }
    }

}
