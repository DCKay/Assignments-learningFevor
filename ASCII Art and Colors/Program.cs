using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art_and_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            var green = ConsoleColor.Green;

            Console.WriteLine("/$$   /$$");
            Console.WriteLine("| $$  /$$/");
            Console.Write("| $$ /$$/");
            Console.ResetColor();
            Console.Write("   /$$$$$$  /$$   /$$\n");
            Console.ForegroundColor = green;
            Console.Write("| $$$$$/");
            Console.ResetColor();
            Console.Write("   |____  $$| $$  | $$\n");
            Console.ForegroundColor = green;
            Console.Write("| $$  $$");
            Console.ResetColor();
            Console.Write("    /$$$$$$$| $$  | $$\n");
            Console.ForegroundColor = green;
            Console.Write("| $$\\  $$");
            Console.ResetColor();
            Console.Write("  /$$__  $$| $$  | $$\n");
            Console.ForegroundColor = green;
            Console.Write("| $$ \\  $$");
            Console.ResetColor();
            Console.Write("|  $$$$$$$|  $$$$$$$\n");
            Console.ForegroundColor = green;
            Console.Write("| __/ \\__/");
            Console.ResetColor();
            Console.Write(" \\_______/ \\____  $$\n");
            Console.WriteLine("                     /$$  | $$");
            Console.WriteLine("                    |  $$$$$$/");
            Console.WriteLine("                     \\______/");
            Console.ReadLine();


        }
    }
}
