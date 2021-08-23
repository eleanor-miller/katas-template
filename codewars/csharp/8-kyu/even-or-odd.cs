/* 
P Given a number if the modulus 2 is 0 it's even, if not is odd.
E 2/2 =1 %0 even, 13/2 = 6 %1 odd, -2/2 = 1 %0even
D int, string,
A   if the number modulus 2 is equal to 0 then the answer is "Even"
    else the answer is "Odd"
C below
*/

using System;

namespace Solution
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
             return "Even";           
            }
            else
            {
             return "Odd";       
            }
        }
    }
}