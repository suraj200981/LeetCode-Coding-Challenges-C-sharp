using System;


namespace TopInterviewQuestionsEasyCollection
{
   public class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { -2,1,-3,4,-1,2,1,-5,4 };
            var testInstance = new Array.MaximumSubArray();


            testInstance.MaxSubArray(nums);
            Console.ReadLine();
        }
    }
}
