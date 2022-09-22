using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeProblems
{
    public class LongestSubstring
    {
        #region singleton
        private LongestSubstring() { }
        private static readonly Lazy<LongestSubstring> lazy = new Lazy<LongestSubstring>(() => new LongestSubstring());
        public static LongestSubstring Instance { get => lazy.Value; }
        #endregion
    
        // Given a string 's', find the length of the longest substring without repeating characters.

        public void Do()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            List<char> chars = new List<char>();

            foreach(char c in s)
            {
                chars.Add(c);
            }

            List<List<char>> subStrings = new List<List<char>>();

            for(int i = 0; i < chars.Count; i++)
            {
                List<char> substr = new List<char>();

                char curr = chars[i];

                substr.Add(curr);
                for(int j = i + 1; j < chars.Count; j++)
                {
                    if(curr != chars[j] && !substr.Contains(chars[j]))
                    {
                        substr.Add(chars[j]);
                    }
                    else
                    {
                        break;
                    }
                }

                subStrings.Add(substr);
            }

            List<char> longestSubstring = subStrings.OrderByDescending(m => m.Count()).First();

            Console.WriteLine($"The answer is [{string.Join(", ", longestSubstring)}], with the length of {longestSubstring.Count}.");
            Console.ReadLine();
        }
    }
}
