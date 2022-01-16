using System;

namespace Algorithms1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testInstance = new MoveZero();

            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            testInstance.MoveZeroes(nums);

        }
    }
}
