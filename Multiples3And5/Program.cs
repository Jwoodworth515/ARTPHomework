using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Please complete the following for Coding Challenge 1:

            Create a new, public repository and add a blank solution.Add a new Console Application project called Multiples3And5.

            If we list all the natural numbers below 10
            that are multiples of 3 or 5, we get 3, 5,
            6 and 9. The sum of these multiples is 23.

            Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.*/



            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is: {sum}\n");

            // The result variable may be initialized as zero because only the (+), (%), (||) operators and (++) incrementer are being used.
            // The for loop will increment the variable i by +1 each time through the loop until the counter reaches 1000.
            // The arg of the if statment nested inside of the for loop will check if the value of i's remainder of 3 OR 5 really equals zero.
            // The executable code inside the body of the if statement uses an assignment operator to assign and reassign the variable i.
            // The Console.WriteLine is writen in using string interpolation to display the result.
            // The output is 233168



            /***********************************************************************************************/

            /*
             * Not my answer but I found interesting on math.stackexchange.com
             * 
             * Solve for 990 to arrive at the sum of all multiples of 3 or 5 below 1000.
             * 
             * (Add the remaining multiple numbers above 990)
             * a = (993+995+996+999)
             * a = 3983
             * 
             * (330 is the divisible number of 990 by 3)
             * b = 330(990 + 3)/2
             * b = 163845
             * 
             * (198 is the divisible number of 990 by 5)
             * c = 198(990 + 5)/2
             * c = 98505
             * 
             * (66 is the amount of instances that 3 and 5 intersect on 15 between 15 and 990)
             * d = 66(990 + 15)/2 
             * d = 33165
             * 
             * (a) + (b) + (c) - (d) = 233168 is the sum of all multiples of 3 or 5 below 1000.
             * 
             */

        }
    }
}
