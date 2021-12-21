using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms1
{

    //this challenge can be found @ https://leetcode.com/problems/squares-of-a-sorted-array/submissions/
    public class SquaresofaSortedArray
    {

        public int[] SortedSquares(int[] nums)
        {
            int[] newArr = new int[nums.Length];
            //first we find the squares of each element in the array
            for (int x=0; x<nums.Length; x++) {
                //check if number is negative
                    newArr[x] = (int)Math.Abs(Math.Pow(nums[x], 2));
            }
            Array.Sort(newArr);

            for (int x = 0; x < newArr.Length; x++)
            {
                //check if number is negative
                return newArr;
            }

            Console.Read();
            return null;
        }

    }
}
