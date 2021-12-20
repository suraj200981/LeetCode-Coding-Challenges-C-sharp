using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Coding_Challenges
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] == target)
                {
                    Console.WriteLine(x);
                    Console.ReadLine();
                    return x;
                }
                else if (x == nums.Length - 1) {
                    if (target > nums[x]) {
                        Console.WriteLine(x + 1);
                        Console.ReadLine();
                        return x + 1;
                    }
                }
                else if (target > nums[x] && target < nums[x + 1] && x != nums.Length - 1)
                {
                    Console.WriteLine(x + 1);
                    Console.ReadLine();
                    return x + 1;
                }
                else
                {
                    continue;
                }
                
            }
            Console.WriteLine(-1);
            Console.ReadLine();
            return 0;
        }
    }
}
