using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        // is a method that adds together two int variables
        public int Add(int num1, int num2) { return num1 + num2; }
         // is a method that subtracts two int variables
        public int Subtract(int num1, int num2) { return num1 - num2; }
        // is a method that multiplies two int variables
        public double Multiply(int num1, int num2) { return (double)num1 * (double)num2; }
        // is a method that divides two int variables
        public double Divide(int num1, int num2) { return (double)num1 / (double)num2; }
        static void Main(string[] args)
        {
            // intializes the class Program as program
            Program program = new Program();
            Console.WriteLine("Give me two numbers");
            Console.WriteLine("Number 1:");

            // reads the line and converts it into an int
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2:");
            // reads the line and converts it into an int
            int num2 = Convert.ToInt32(Console.ReadLine());

            // calls upon method Add
            int Addition = program.Add(num1, num2);
            // calls upon method Subtract
            int Subtraction = program.Subtract(num1, num2);
            // calls upon method Multiply
            double Multiplication = program.Multiply(num1, num2);
            // calls upon method Divide
            double Division = program.Divide(num1, num2);

            // writes out everything
            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Subtraction: {Subtraction}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Division: {Division}");

        }
    }
}
