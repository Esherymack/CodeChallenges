using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Do()
        {
            Console.WriteLine("Enter a string to convert: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the number of rows: ");
            int numRows = 0;
            int.TryParse(Console.ReadLine(), out numRows);

            int length = s.Length;

            if(length % numRows == 0)
            {

            }
            else
            {

            }

        }
    }
}