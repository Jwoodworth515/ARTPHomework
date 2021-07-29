using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create a new, public repository and add a blank solution.Add a new Console Application project called FibonacciEvenSum.

            Each new term in the Fibonacci sequence is generated
            by adding the previous two terms.By starting with
            1 and 2, the first 10 terms will be:

            1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            Remember to commit changes to the repository. Submit your repo url to this assignment. */

            //Numbers to be added together 2, 8, 34, 144, 610, 2584, 10946, 46386, 196418, 832040, 3524578 = 
            //4613732 is the target result

            long fnumber1 = 1;
            long fnumber2 = 1;
            long result = 0;
            long sum = 0;

            while (result < 4000000)
            {
                if ((result % 2) == 0)
                {
                    sum += result;
                }
                result = fnumber1 + fnumber2;
                fnumber2 = fnumber1;
                fnumber1 = result;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

            // I created 4 variables for this challenge to handle the Fibbonaci equation using a while loop.  I will likely refactor later as I now know there is a way to do this with only two variables
            // Setting the condition of the while loop to 4000000 so once the result variable reaches that number it will break out of the loop.
            //the if statment is checking to see if the result variable's remainder is really equal to 0, this determines if the number is equal or not.  
            //If equal, the result variable falls into the body of the if statment and uses an assignment operator to assign and add the value to the variable sum.
            //If the value of result is not really equal to zero it wil skip the if statments body and move back into the while loops body and continue compiling code.
            //The result is given the value of fnumber1 + fnumber2's variables.
            //Next fnumber2 is reassigned the value of fnumber1.
            //Next fnumber 1 is assigned the value of result and is delivered back to the counter and checked against the condition of the while loop.
            // The Console.WriteLine is writen in using string interpolation to display the result.
            // The output is 4613732

        }
    }
}
