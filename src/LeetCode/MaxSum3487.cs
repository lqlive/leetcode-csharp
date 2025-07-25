namespace LeetCode;
public class MaxSum3487
{
    public int MaxSum(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var item in nums)
        {
            if (item > 0)
            {
                set.Add(item);
            }
        }

        if (set.Count == 0)
        {
            return nums.Max();
        }

        return set.Sum();
    }
}
