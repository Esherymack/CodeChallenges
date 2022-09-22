using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProblems
{
    public class ZigzagConversion
    {
        #region singleton
        private ZigzagConversion() { }
        private static readonly Lazy<ZigzagConversion> lazy = new Lazy<ZigzagConversion>(() => new ZigzagConversion());
        public static ZigzagConversion Instance { get => lazy.Value; }
        #endregion

        // The string 'PAYPALISHIRING' is written in a zigzag pattern on a given
        // number of rows like this:
        // P   A   H   N
        // A P L S I I G
        // Y   I   R
        // And then read line by line: 'PAHNAPLSIIGYIR"
        // Write the code that will take a string and make this conversion
        // given a number of rows.
        

        // I gave up on this one and cheated. It's a C# implementation of one of the 
        // solutions to the problem.
        public void Do()
        {
            Console.WriteLine("Enter a string to convert: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the number of rows: ");
            int.TryParse(Console.ReadLine(), out int numRows);

            if(numRows == 1)
            {
                Console.WriteLine($"[{s}]");
            }
            else
            {
                List<StringBuilder> rows = new List<StringBuilder>();

                for (int i = 0; i < (numRows < s.Length ? numRows : s.Length); i++)
                {
                    rows.Add(new StringBuilder());
                }

                int currentRow = 0;
                bool goingDown = false;

                foreach (char c in s)
                {
                    rows[currentRow].Append(c);
                    if (currentRow == 0 || currentRow == numRows - 1)
                    {
                        goingDown = !goingDown;
                    }

                    currentRow += goingDown ? 1 : -1;
                }

                StringBuilder final = new StringBuilder();
                foreach (StringBuilder sb in rows)
                {
                    final.Append(sb);
                }

                Console.WriteLine($"[{final}]");
            }
        }
    }
}