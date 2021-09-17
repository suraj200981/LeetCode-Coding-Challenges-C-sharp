using System;


namespace LeetCode_Coding_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 3, 2, 4 };

            Console.WriteLine("Hello World!");

            var TwoSumInstance = new TwoSum();
            //converting int array to string, can remove from leetcode after
            string result = string.Join(",", TwoSumInstance.TwoSumFunc(nums, 6));
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
