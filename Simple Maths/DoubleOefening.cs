using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_learningFevor
{
    class DoubleOefening
    {
        public static void Run()
        {
            //Basics: Simple maths
            //1
            Console.WriteLine($"-1 + 4* 6 = {-1 + 4 * 6}");
            double a = -1 + 4 * 6.0;
            Console.WriteLine($"-1 + 4* 6 = {a}");

            //2
            Console.WriteLine($"( 35 + 5 ) % 7 = {(35 + 5) % 7}");
            double b = (35 + 5) % 7.0;
            Console.WriteLine($"( 35 + 5 ) % 7 = {b}");

            //3
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            double c = 14 + -4 * 6 / 11.0;
            Console.WriteLine($"14 + -4 * 6 / 11 = {c}");

            //4
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
            double d = 2 + 15 / 6.0 * 1 - 7 % 2.0;
            double t = 2 + 15 / 6 * 1 - 7 % 2.0;
            double i = 2 + 15 / 6.0 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {d}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {t}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {i}");

            //5
            Console.WriteLine($"7 / 3 = {7 / 3}");
            double e = 7 / 3.0;
            Console.WriteLine($"7 / 3 = {e}");

            //6
            int f = 7 / (int)3.0;
            Console.WriteLine($"7 / 3.0 = {f}");
            Console.WriteLine($"7 / 3.0 = {7 / 3.0}");
        }
    }
}
