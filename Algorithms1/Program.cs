using System;

namespace Algorithms1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testInstance = new RotateArray();

            int[] nums = new int[] { -1, -100, 3, 99 };
            testInstance.Rotate(nums, 2);

        }
    }
}
