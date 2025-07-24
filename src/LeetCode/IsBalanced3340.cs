
namespace LeetCode;
public class IsBalanced3340
{
    public bool IsBalanced(string num)
    {
        var diff = 0;
        var sign = 1;

        foreach (var c in num)
        {
            var d = (int)char.GetNumericValue(c);
            diff+= d * sign;
            sign = -sign;
        }

        return diff == 0;
    }
}
