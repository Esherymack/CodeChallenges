using System;
using System.Collections.Generic;

namespace CodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Modules = new List<string>()
            {
                "TwoSum",
                "AddTwoNumbers",
                "LongestSubstring",
                "Median_TwoSortedArrays",
                "LongestPalindromicSubstring",
                "ZigZagConversion",
                "ReverseInteger"

            };

            string input = string.Empty;

            while(input != "exit")
            {
                if(input == "exit")
                {
                    break;
                }

                Console.WriteLine("Which module to run?: ");
                foreach (string s in Modules)
                {
                    Console.WriteLine($"{Modules.IndexOf(s) + 1}. {s}");
                }

                input = Console.ReadLine();

                if(!int.TryParse(input, out int val))
                {
                    if(!input.Equals("exit"))
                    {
                        Console.WriteLine("Input must be a valid number or 'exit'");
                    }
                    else
                    {
                        break;
                    }
                }

                switch (val)
                {
                    case 1:
                        TwoSum.Instance.Do();
                        break;
                    case 2:
                        AddTwoNumbers.Instance.Do();
                        break;
                    case 3:
                        LongestSubstring.Instance.Do();
                        break;
                    case 4:
                        Median_TwoSortedArrays.Instance.Do();
                        break;
                    case 5:
                        LongestPalindromicSubstring.Instance.Do();
                        break;
                    case 6:
                        ZigzagConversion.Instance.Do();
                        break;
                    case 7:
                        ReverseInteger.Instance.Do();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
