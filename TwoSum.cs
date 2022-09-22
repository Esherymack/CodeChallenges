using System;
using System.Collections.Generic;

namespace CodeProblems
{
    public class TwoSum
    {
        #region singleton
        private TwoSum() { }
        private static readonly Lazy<TwoSum> lazy = new Lazy<TwoSum>(() => new TwoSum());
        public static TwoSum Instance { get => lazy.Value; }
        #endregion

        // given an array of integers 'nums' and an integer 'target', 
        // return indices of the two numbers such that they add up to 'target'.
        // you may assume that each input would have exactly one solution, and you may
        // not use the same element twice.
        // you can return the answer in any order.

        int[] nums { get; set; }
        List<int> num_list { get; set; }
        int target { get; set; }

        public void Do()
        {
            num_list = new List<int>();
            string input = string.Empty;
            while(input != "-1")
            {
                Console.Write("Enter a number (-1 to finish): ");
                input = Console.ReadLine();

                if(!int.TryParse(input, out int result_inner))
                {
                    Console.WriteLine("Input must be a number greater than or equal to 0.");
                }
                else if(result_inner > 0)
                {
                    num_list.Add(result_inner);
                }
                else
                {
                    break;
                }
            }

            nums = num_list.ToArray();

            Console.Write("Enter 'target': ");
            
            input = Console.ReadLine();
            bool success = int.TryParse(input, out int result);

            while (!success)
            {
                Console.WriteLine("Invalid input; try again.");
                Console.Write("Enter 'target': ");
                input = Console.ReadLine();
                success = int.TryParse(input, out result);
            }

            target = result;
            int[] result_array = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && nums[i] != nums[j])
                    {
                        result_array[0] = nums[i];
                        result_array[1] = nums[j];
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine($"[{Array.IndexOf(nums, result_array[0])}, {Array.IndexOf(nums, result_array[1])}]");
        }
    }
}
