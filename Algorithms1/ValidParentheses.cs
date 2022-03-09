using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms1
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            for (int x = 0; x < s.Length; x++) {

                if (s.Length ==2 && (s[x] == '(' && s[x + 1] != ')') || (s[x] == '{' && s[x + 1] != '}') || (s[x] == '[' && s[x + 1] != ']')) {

                    return false;
                }
                else if (x != s.Length - 1 && (s[x] == '(' && s[x + 1] == ')') || (s[x] == '{' && s[x + 1] == '}') || (s[x] == '[' && s[x + 1] == ']'))
                {
                    return true;
                }
                else if (x != s.Length - 1 && (s[x + 1] == '(' && s[x + 2] == ')') || (s[x + 1] == '{' && s[x + 2] == '}') || (s[x + 1] == '[' && s[x + 2] == ']')) {
                    return true;

                }
                /*         else if (s[x] == ')')
                         {
                             return false;

                         }*/
                else
                {
                    return false;
                }

            }
            return false;
        }
    }
}
