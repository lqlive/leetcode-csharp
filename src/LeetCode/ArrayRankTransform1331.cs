using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class ArrayRankTransform1331
{
    public int[] ArrayRankTransform(int[] arr)
    {
        var map = new Dictionary<int, int>();

        var orderedList = arr.OrderBy(x => x);

        foreach (var item in orderedList)
        {
            map.TryAdd(item, map.Count + 1);
        }

        var result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = map[arr[i]];
        }
        return result;
    }
}