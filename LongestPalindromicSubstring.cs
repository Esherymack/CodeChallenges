using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeProblems
{
    public class LongestPalindromicSubstring
    {
        #region singleton
        private LongestPalindromicSubstring() { }
        private static readonly Lazy<LongestPalindromicSubstring> lazy = new Lazy<LongestPalindromicSubstring>(() => new LongestPalindromicSubstring());
        public static LongestPalindromicSubstring Instance { get => lazy.Value; }
        #endregion

        // Given a string 's', return the longest palindromic substring in 's'. A string
        // is called a palindrome string if the reverse of the string is the same as the
        // original string.

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

            for (int i = 0; i <= s.Length; i++)
            {
                for (int j = 0; j < s.Length && j + i < s.Length; j++)
                {
                    string f = s.Substring(j, i);
                    List<char> substrArr = new List<char>();
                    foreach (char c in f)
                    {
                        substrArr.Add(c);
                    }
                    subStrings.Add(substrArr);
                }
            }

            List<List<char>> orderedSubstrings = subStrings.OrderByDescending(m => m.Count()).ToList();
            List<List<char>> orderedCopy = new List<List<char>>(orderedSubstrings);
            List<char> substringFound = new List<char>();

            foreach(List<char> substrList in orderedSubstrings)
            {
                List<char> reversed = new List<char>(substrList);
                reversed.Reverse();

                if(reversed.SequenceEqual(substrList))
                {
                    substringFound = substrList;
                    break;
                }
                else
                {
                    orderedCopy.Remove(substrList);
                    continue;
                }
            }

            Console.WriteLine($"The longest palindromic substring is [{string.Join(", ", substringFound)}]");
            Console.ReadLine();

        }

    }
}
