using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_learningFevor
{
    class IntOefening
    {
        public static void Run()
        {
            //Basics: Simple maths
            //1
            Console.WriteLine($"-1 + 4* 6 = {-1 + 4 * 6}");
            int a = -1 + 4 * 6;
            Console.WriteLine($"-1 + 4* 6 = {a}");

            //2
            Console.WriteLine($"( 35 + 5 ) % 7 = {(35 + 5) % 7}");
            int b = (35 + 5) % 7;
            Console.WriteLine($"( 35 + 5 ) % 7 = {b}");

            //3
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            int c = 14 + -4 * 6 / 11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {c}");

            //4
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
            int d = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {d}");

            //5
            Console.WriteLine($"7 / 3 = {7 / 3}");
            int e = 7 / 3;
            Console.WriteLine($"7 / 3 = {e}");

            //6
            double f = 7 / 3.0;
            Console.WriteLine($"7 / 3.0 = {f}");
            Console.WriteLine($"7 / 3.0 = {7 / 3.0}");
        }
    }
}
