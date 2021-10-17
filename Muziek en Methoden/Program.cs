using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziek_en_Methoden
{
    class Program
    {
        public static void Do(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Do");
            int beep = 264;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }

        }
        public static void Re(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Re");
            int beep = 297;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }
        public static void Mi(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mi");
            int beep = 330;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }
        public static void Fa(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Fa");
            int beep = 352;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }
        public static void Sol(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sol");
            int beep = 396;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }
        public static void La(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La");
            int beep = 440;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }
        public static void Si(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Si");
            int beep = 495;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }
        public static void Do2(int mSeconden, int octaaf)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do");
            int beep = 528;
            switch (octaaf)
            {
                case 1:
                    Console.Beep(beep, mSeconden);
                    break;
                case 2:
                    Console.Beep(Convert.ToInt32(beep * 1.5), mSeconden);
                    break;

            }
        }

        public static void SpeelYouAreMySunshine()
        {
            /* G = Re
             * C = Sol
             * D = La
             * E = Si
             * F = Do2
             * A = Mi
             */
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            // TODO: De waardes 1000 voor mSecoden en 1 voor octaaf worden vaak herhaald. Kan je hier default values van maken?
            Re(1000, 1);
            Sol(1300, 1);
            La(1400, 1);
            Si(1500, 1);
            Si(1500, 1);
            Si(1500, 1);
            La(1400, 2);
            Si(1500, 1);
            Sol(1300, 1);
            Sol(1300, 1);

            Sol(1000, 1);
            La(1200, 1);
            Si(1300, 1);
            Do2(1400, 1);
            Mi(1500, 1);
            Mi(1500, 1);
            Re(1400, 1);
            Do2(1300, 1);
            Si(1200, 1);

            Sol(1000, 1);
            La(1200, 1);
            Si(1300, 1);
            Do2(1400, 1);
            Mi(1500, 1);
            Mi(1500, 1);
            Re(1400, 1);
            Do2(1400, 1);
            Si(1200, 1);
            Sol(1000, 1);

            Sol(1000, 1);
            La(1200, 1);
            Si(1300, 1);
            Do2(1400, 1);
            La(1200, 1);
            La(1200, 1);
            Si(1300, 1);
            Sol(1000, 1);

            stopwatch.Stop();
            double totaletijd = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine($"{(int)totaletijd} seconden");
        }
        static void Main(string[] args)
        {
            SpeelYouAreMySunshine();
        }
    }
}
