using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class CanCompleteCircuit134
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var n = gas.Length;
        var i = 0;
        while (i < n)
        {
            int sumOfGas = 0, sumOfCost = 0;
            int count = 0;
           
            while (count < n)
            {
                var j = (i + count) % n;
                sumOfGas += gas[j];
                sumOfCost += cost[j];

                if (sumOfCost > sumOfGas)
                {
                    break;
                }
                count ++;
            }

            if (count == n)
            {
                return i;
            }
            else 
            {
                i = i + count + 1;
            }
        }
        return -1;
    }
}
