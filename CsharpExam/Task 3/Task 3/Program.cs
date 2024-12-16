using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string array with names
            string[] names = new string[]
            {
                "Bob", "Steve", "Nina"
            };

            // integer array with numbers
            int[] numbers = new int[]
            {
                5, 57, 87, 1, 150, 32, 14
            };


            // prints every name with goodbye at the beginning using foreach
            foreach (string name in names)
            {
                Console.WriteLine($"Goodbye {name}");
            }

            // sorts the numbers in ascending order
            Array.Sort(numbers);
            // removes last item from the array
            Array.Resize(ref numbers, numbers.Length - 1);

            // prints every number using foreach
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
