using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Coding_Challenges
{
    public class BinarySearch
    {

        /*Please see exercise overview @ https://leetcode.com/problems/binary-search/ */
        public int Search(int[] nums, int target)
        {
            Console.WriteLine(69);


            for (int x = 0; x < nums.Length; x++) {
                if (nums[x] == target) {
                    return x;
                }
            }
            return -1;
        }
    }
}
