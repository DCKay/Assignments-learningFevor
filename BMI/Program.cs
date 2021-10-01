using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        enum BodyMassIndex
        {
            Ernstigezwaarlijvigheid,
            Zwaarlijvig,
            Overgewicht,
            NormaalGewicht,
            Ondergewicht
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Geef mij uw lengte in cm");
            double lengteCmeter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef mij uw gewicht in kg");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            double BMI = Math.Round(gewicht / Math.Pow((lengteCmeter / 100), 2));
            Console.WriteLine($"Uw BMI bedraagt : {Math.Round(gewicht / Math.Pow((lengteCmeter / 100), 2))}");
            if (BMI <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{BodyMassIndex.Ondergewicht}");
            }
            else if (BMI >= 18.6 && BMI <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{BodyMassIndex.NormaalGewicht}");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{BodyMassIndex.Overgewicht}. Je loopt niet echt een risico, maar je mag niet dikker worden.");
            }
            else if (BMI >= 30 && BMI <= 39.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{BodyMassIndex.Zwaarlijvig} (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{BodyMassIndex.Ernstigezwaarlijvigheid}. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
            }
            Console.ReadLine();
        }
    }
}
