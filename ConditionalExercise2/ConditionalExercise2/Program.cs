using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise2
{
    class Program
    {
        // Write a program which takes two numbers from the console and displays the maximum of the two.
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The max number of the two you entered is: " + max);
        }
    }
}
