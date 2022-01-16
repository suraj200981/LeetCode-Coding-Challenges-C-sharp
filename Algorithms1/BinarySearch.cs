using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms1
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] == target)
                {
                    return x;
                }
            }
            return -1;
        }
    }
}
