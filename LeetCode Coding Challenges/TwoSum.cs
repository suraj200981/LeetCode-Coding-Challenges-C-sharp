using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Coding_Challenges
{
/* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
   You may assume that each input would have exactly one solution, and you may not use the same element twice.
   You can return the answer in any order.*/

   public class TwoSum
    {

        public int[] TwoSumFunc(int[] nums, int target)
        {
            int[] inputArr = nums;
            int inputTargetNum = target;

            int[] resultArr = new int[2];

            for (int x = 0; x < inputArr.Length; x++) {
                for (int i = x+1; i < inputArr.Length; i++)
                {
                    if (inputArr[x] + inputArr[i]==inputTargetNum) {

                        resultArr[0] = x;
                        resultArr[1] = i;

                       return resultArr;
                    }
                }
            }
            return resultArr;
        }
    }
}
