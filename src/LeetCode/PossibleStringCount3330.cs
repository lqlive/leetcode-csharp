namespace LeetCode;
public class PossibleStringCount3330
{
    public int PossibleStringCount(string word)
    {
        var length = word.Length;
        var ans = 1;
        for (var i = 1; i < length; i++)
        {
            if (word[i] == word[i-1])
            {
                ans++;
            }
        }
        return ans;
    }
}
