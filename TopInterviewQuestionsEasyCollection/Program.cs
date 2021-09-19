using System;


namespace TopInterviewQuestionsEasyCollection
{
   public class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            var testInstance = new Array.Remove_Duplicates_from_Sorted_Array();


            testInstance.RemoveDuplicates(nums);
            Console.ReadLine();
        }
    }
}
