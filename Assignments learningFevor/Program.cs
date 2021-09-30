using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_learningFevor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basics: Simple maths
            //1
            Console.WriteLine($"-1 + 4* 6 = {-1 + 4 * 6}");
            double a = -1 + 4 * (double)6;
            Console.WriteLine($"-1 + 4* 6 = {a}");
            //2
            Console.WriteLine($"( 35 + 5 ) % 7 = {(35 + 5) % 7}");
            double b = (35 + 5) % (double)7;
            Console.WriteLine($"( 35 + 5 ) % 7 = {b}");
            //3
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            double c = 14 + -4 * 6 / (double)11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {c}");
            //4
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
            double d = 2 + 15 / (double)6 * 1 - 7 % (double)2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {d}");
            //5
            Console.WriteLine($"7 / 3 = {7 / 3}");
            double e = 7 / (double)3;
            Console.WriteLine($"7 / 3 = {e}");
            //6
            int f = 7 / (int)3.0;
            Console.WriteLine($"7 / 3.0 = {f}");
            Console.WriteLine($"7 / 3.0 = {7 / 3.0}");
            Console.ReadLine();
        }
    }
}
