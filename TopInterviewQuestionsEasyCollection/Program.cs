using System;


namespace TopInterviewQuestionsEasyCollection
{
   public class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3,3,3, 3, 4 };
            var testInstance = new Array.Remove_Duplicates_from_Sorted_Array();


            testInstance.RemoveDuplicates(nums);
            Console.ReadLine();
        }
    }
}
