using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms1
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int temp;
            for (int x = 0; x < k; x++) {
                for (int y=nums.Length-1; y>0; y--) {
                    temp = nums[y]; 
                    nums[y] = nums[y - 1];
                    nums[y - 1] = temp;
                    string myStringOutput = String.Join(",", nums.Select(p => p.ToString()).ToArray());

                    //Console.WriteLine(myStringOutput);
                }
            }

            for (int x = 0; x<nums.Length; x++) {
                Console.Write(nums[x]+", ");
            }
            Console.Read();
        }
    }
}
