using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProblems
{
    public class AddTwoNumbers
    {
        #region singleton
        private AddTwoNumbers() { }
        private static readonly Lazy<AddTwoNumbers> lazy = new Lazy<AddTwoNumbers>(() => new AddTwoNumbers());
        public static AddTwoNumbers Instance { get => lazy.Value; }
        #endregion

        // You are given two non-empty linked lists representing two non-negative
        // integers. The digits are stored in reverse order, and each of their nodes
        // contains a single digit. Add the two numbers and return the sum as a linked list.
        // You may assume the two numbers do not contain any leading zero, except the number
        // 0 itself.

        LinkedList<int> List1 { get; set; }
        LinkedList<int> List2 { get; set; }

        public void Do()
        {
            List1 = new LinkedList<int>();
            List2 = new LinkedList<int>();

            string input = string.Empty;
            Console.Write("Enter the first number (must be >= 0): ");
            input = Console.ReadLine();

            if (!int.TryParse(input, out int result_inner) && result_inner < 0)
            {
                Console.WriteLine("Input must be a number greater than or equal to 0.");
                return;
            }
            else
            {
                char[] input_arr = input.ToCharArray();
                foreach(char c in input_arr)
                {
                    _ = int.TryParse(c.ToString(), out int res);
                    LinkedListNode<int> tmp = new LinkedListNode<int>(res);
                    List1.AddFirst(tmp);
                }
            }

            Console.Write("Enter the second number (must be >= 0): ");
            input = Console.ReadLine();

            if(!int.TryParse(input, out result_inner) && result_inner < 0)
            {
                Console.WriteLine("Input must be a number greater than or equal to 0.");
                return;
            }
            else
            {
                char[] input_arr = input.ToCharArray();
                foreach(char c in input_arr)
                {
                    _ = int.TryParse(c.ToString(), out int res);
                    LinkedListNode<int> tmp = new LinkedListNode<int>(res);
                    List2.AddFirst(tmp);
                }
            }

            // we need to sum the numbers

            // so we need to read from the end of the list to the front of the list to get each number
            LinkedListNode<int> el = List1.Last;
            string int1 = string.Empty;

            StringBuilder sb = new StringBuilder();

            while(el != null)
            {
                int val = el.Value;
                sb.Append(val);
                el = el.Previous;
            }

            int1 = sb.ToString();
            sb.Clear();

            el = List2.Last;
            string int2 = string.Empty;

            while(el != null)
            {
                int val = el.Value;
                sb.Append(val);
                el = el.Previous;
            }

            int2 = sb.ToString();
            sb.Clear();

            int Int1 = int.Parse(int1);
            int Int2 = int.Parse(int2);

            int sum = Int1 + Int2;

            var result = new List<int>();

            while(sum != 0)
            {
                result.Insert(0, sum % 10);
                sum /= 10;
            }

            LinkedList<int> SumLL = new LinkedList<int>();
            foreach (int i in result)
            {
                LinkedListNode<int> num = new LinkedListNode<int>(i);
                SumLL.AddFirst(num);
            }

            el = SumLL.Last;

            while(el != null)
            {
                int val = el.Value;
                sb.Append(val);
                el = el.Previous;
            }

            Console.WriteLine(sb.ToString());
            sb.Clear();
            
            Console.ReadLine();
        }
    }
}
