using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems
{
    public class ReverseInteger
    {
        #region singleton

        private ReverseInteger() { }
        private static readonly Lazy<ReverseInteger> lazy = new Lazy<ReverseInteger>(() => new ReverseInteger());
        public static ReverseInteger Instance
        {
            get => lazy.Value;
        }

        #endregion

        public void Do()
        {

        }
    }
}
