using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");

            // converts users input into an integer
            int input = Convert.ToInt32(Console.ReadLine());

            // if the input is greater than zero it does the thing within the {} which is printing "number is positive"
            if (input > 0)
            {
                Console.WriteLine("Number is positive");
            }
            // if the input is lesser than zero it does the thing within the {}
            else if (input < 0)
            {
                Console.WriteLine("Number is negative");
            }
            // if the input is equal to zero it does the thing within the {}
            else if (input == 0)
            {
                Console.WriteLine("Number is zero");
            }
            // anything else than above prints that the input is invalid
            else
            {
                Console.WriteLine("Input is invalid");
            }
        }
    }
}
