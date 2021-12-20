using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Coding_Challenges
{
 /* Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    Assume the environment does not allow you to store 64-bit integers(signed or unsigned).*/

/*    Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
Example 4:

Input: x = 0
Output: 0*/

    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            StringBuilder sb = new StringBuilder();
            string str = x.ToString();
            string newStr;
            int a;

            bool negativeNumber;
            if (str[0] == '-')
            {
                negativeNumber = true;
                str = str.Replace("-", "");
            }
            else {
                negativeNumber = false;
                str.Replace("-", "");
            }
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            for (int i = 0; i < charArray.Length; i++) {

                sb.Append(charArray[i]);
            }

            newStr = sb.ToString();
            if (newStr.Length >= 2) {
                if (newStr[0]=='0') {
                    newStr = newStr.Substring(1);
                }
            }


            if (negativeNumber)
            {
                return -Int32.Parse(newStr);

            }
            else
            {
                return (int)uint.Parse(newStr);

            }
        }

    }
}
