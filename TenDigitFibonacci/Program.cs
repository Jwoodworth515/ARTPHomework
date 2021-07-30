using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a new, public repository and add a blank solution.Add a new Console Application project called TenDigitFibonacci.

            The Fibonacci sequence is defined by the recurrence relation:

            Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.

            What is the index of the first term in the Fibonacci sequence to contain 10 digits?*/

            //The Answer is the index of 45, now how do we get there using C#



            do
            {

            } while ( >= 45);



            long fnumber1 = 1;
            long fnumber2 = 1;
            long result = 0;
            long sum = 0;

            while (result <= 1500000000)
            {
                if (sum <= 1500000000)
                {
                    sum += result;
                }
                result = fnumber1 + fnumber2;
                fnumber2 = fnumber1;
                fnumber1 = result;
            }
            Console.WriteLine(sum);
            Console.ReadLine();


        }
    }
}
