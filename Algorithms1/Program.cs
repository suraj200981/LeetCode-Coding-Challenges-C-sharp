using System;


namespace Algorithms1
{


class Program
    {
        public class ZigzagConversion {

            public string Convert(string s, int numRows)
            {
                int count = 0;
                
                    for (int x = 0; x < s.Length; x++) {

                        if (count == numRows)
                        {
                            break;
                        }
                        if (x %2==0) {
                            for (int k=x; k<s.Length; k+=numRows+1) {
                                Console.Write(s[k] + " ");

                            }
                            count++;
                            
                        }
                        if (x %2!=0)
                        {
                            for (int k = x; k < s.Length; k += numRows - 1)
                            {
                                Console.Write(s[k] + " ");

                            }
                            count++;
                        }

                        Console.WriteLine();


                    }

                return null;
            }
        }
   public static void Main(string[] args)
        {
            var testInstance = new ZigzagConversion();

            string str = "PAYPALISHIRING";


            Console.WriteLine(testInstance.Convert(str, 4));
            Console.ReadLine();

        }
    }
}
