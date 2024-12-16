using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an integer");
            // reads the line and converts it into a int
            int integervar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me a double");
            // reads the line and converts it into a double
            double doublevar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give me a float");
            // reads the line and converts it into a float
            float floatvar = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me a string");
            // reads the line and converts it into a string
            string stringvar = Convert.ToString(Console.ReadLine());

            Console.WriteLine(integervar);
            Console.WriteLine(doublevar);
            Console.WriteLine(floatvar);
            Console.WriteLine(stringvar);
            Console.WriteLine("An integer variable is a whole number, a double is a number that can store up to 15 decimals, a float is a number that can store up to 6-7 decimals and a string is a text variable");
        }
    }
}
