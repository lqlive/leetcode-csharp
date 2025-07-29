using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class ShortestCompletingWord748
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        var plateLetters = licensePlate.
            Where(char.IsLetter)
            .Select(char.ToLower)
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        return words.Where(word => IsCompletingWord(word, plateLetters))
            .OrderBy(word => word.Length)
            .First();
    }
    private bool IsCompletingWord(string word, Dictionary<char, int> plateLetters)
    {
        var wordLetters = word.
            Select(char.ToLower)
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        return plateLetters.All(kvp => wordLetters.GetValueOrDefault(kvp.Key, 0) >= kvp.Value);

    }
}
