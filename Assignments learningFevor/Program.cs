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
            Console.Clear();

            //Basic: Gewicht in space
            /*Mercurius: 0.38
            * Venus: 0.91
            * Aarde: 1.00
            * Mars: 0.38
            * Jupiter: 2.34
            * Saturnus: 1.06
            * Uranus: 0.92
            * Neptunus: 1.19
            * Pluto: 0.06*/
            Console.WriteLine("Uw gewicht in kg?");
            double gewichtOpAarde = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nGewicht op Aarde: "+ gewichtOpAarde +" kg.");
            Console.WriteLine($"Gewicht op Mercurius: " + gewichtOpAarde*.38 + " kg.");
            Console.WriteLine($"Gewicht op Venus: " + gewichtOpAarde*.91 + " kg.");
            Console.WriteLine($"Gewicht op Mars: " + gewichtOpAarde*.38 + " kg.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Gewicht op Jupiter: " + gewichtOpAarde*2.34 + " kg.");
            Console.ResetColor();
            Console.WriteLine($"Gewicht op Saturnus: " + gewichtOpAarde*1.06 + " kg.");
            Console.WriteLine($"Gewicht op Uranus: " + gewichtOpAarde*.92 + " kg.");
            Console.WriteLine($"Gewicht op Neptunus: " + gewichtOpAarde*1.19 + " kg.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gewicht op Pluto: " + gewichtOpAarde*.06 + " kg.");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
