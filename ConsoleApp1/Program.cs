using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("\nGewicht op Aarde: " + gewichtOpAarde + " kg.");
            Console.WriteLine("Gewicht op Mercurius: " + gewichtOpAarde * .38 + " kg.");
            Console.WriteLine("Gewicht op Venus: " + gewichtOpAarde * .91 + " kg.");
            Console.WriteLine("Gewicht op Mars: " + gewichtOpAarde * .38 + " kg.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Gewicht op Jupiter: " + gewichtOpAarde * 2.34 + " kg.");
            Console.ResetColor();
            Console.WriteLine("Gewicht op Saturnus: " + gewichtOpAarde * 1.06 + " kg.");
            Console.WriteLine("Gewicht op Uranus: " + gewichtOpAarde * .92 + " kg.");
            Console.WriteLine("Gewicht op Neptunus: " + gewichtOpAarde * 1.19 + " kg.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gewicht op Pluto: " + gewichtOpAarde * .06 + " kg.");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
