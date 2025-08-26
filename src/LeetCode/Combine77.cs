using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class Combine77
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var temp = new List<int>();
        var ans = new List<IList<int>>();

        for (int i = 1; i <=k; ++i)
        {
            temp.Add(i);
        }

        temp.Add(n + 1);

        int j = 0;

        while (j < k)
        {
            ans.Add(new List<int>(temp.Slice(0, k)));
            j = 0;

            while (j < k && temp[j] + 1 == temp[j + 1])
            {
                temp[j] = j + 1;
                ++j;
            }
            temp[j] = temp[j] + 1;
        }

        return ans;
    }
}
