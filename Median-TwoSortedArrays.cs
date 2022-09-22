using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems
{
    public class Median_TwoSortedArrays
    {
        #region singleton
        private Median_TwoSortedArrays() { }
        private static readonly Lazy<Median_TwoSortedArrays> lazy = new Lazy<Median_TwoSortedArrays>(() => new Median_TwoSortedArrays());
        public static Median_TwoSortedArrays Instance { get => lazy.Value; }
        #endregion
        // Given two sorted arrays 'nums1' and 'nums2' of size 'm' and 'n' respectively,
        // return the median of the two sorted arrays.

        public void Do()
        {
            int?[] nums1 = new int?[1048];
            int?[] nums2 = new int?[1048];

            string input = string.Empty;

            int i = 0;
            while (i != 1048)
            {
                Console.Write("Array 1: Enter a number ('done' to finish): ");
                input = Console.ReadLine();

                if (input.Equals("done"))
                {
                    i = 1048;
                    break;
                }
                else
                {
                    if(int.TryParse(input, out int res))
                    {
                        nums1[i] = res;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Input must be a number.");
                    }
                }
            }
            i = 0;
            while(i != 1048)
            {
                Console.Write("Array 2: Enter a number ('done' to finish): ");
                input = Console.ReadLine();
                if(input.Equals("done"))
                {
                    i = 1048;
                    break;
                }
                else
                {
                    if(int.TryParse(input, out int res))
                    {
                        nums2[i] = res;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Input must be a number.");
                    }
                }
            }

            int size_nums1 = nums1.Count(x => x != null);
            int size_nums2 = nums2.Count(x => x != null);

            Array.Resize(ref nums1, size_nums1);
            Array.Resize(ref nums2, size_nums2);

            int?[] combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined);

            int count_combined = combined.Count();
            int half_idx = count_combined / 2;
            double median = 0.0;

            if(count_combined % 2 == 0)
            {
                median = (double)((combined.ElementAt(half_idx) + combined.ElementAt(half_idx - 1))) / 2;
            }
            else
            {
                median = (double)combined.ElementAt(half_idx);
            }

            //Console.WriteLine($"[{string.Join(", ", combined)}]");
            Console.WriteLine($"The median is {median}.");

            Console.ReadLine();        
        }
    }
}
