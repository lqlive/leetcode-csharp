using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class CombinationSum39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var ans = new List<IList<int>>();
        var combine = new List<int>();
        DFS(candidates, target, ans, combine, 0);
        return ans;
    }

    private void DFS(int[] candidates,int target, List<IList<int>> ans,List<int> combine,int index)
    {
        if (index == candidates.Length)
        {
            return;
        }

        if (target == 0)
        {
            ans.Add(new List<int>(combine));
            return;
        }

        DFS(candidates, target, ans, combine, index + 1);

        if (target - candidates[index] >= 0)
        {
            combine.Add(candidates[index]);

            DFS(candidates, target - candidates[index], ans, combine, index);

            combine.RemoveAt(combine.Count - 1);
        }
    }
}
