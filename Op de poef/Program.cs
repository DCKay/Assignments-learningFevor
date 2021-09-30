using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totaalTab = 0;
            Console.WriteLine("Voer bedrag in?");
            decimal bedrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"De poef staat op {totaalTab += bedrag} euro.");
            Console.WriteLine("Voer bedrag in?");
            bedrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"De poef staat op {totaalTab += bedrag} euro.");
            Console.WriteLine("Voer bedrag in?");
            bedrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"De poef staat op {totaalTab += bedrag} euro.");
            Console.WriteLine("Voer bedrag in?");
            bedrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"De poef staat op {totaalTab += bedrag} euro.");
            Console.WriteLine("Voer bedrag in?");
            bedrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"De poef staat op {totaalTab += bedrag} euro.");
            Console.WriteLine($"\n********************** \nHet totaal van de poef is {totaalTab} en zal {Math.Round((totaalTab / 10))} weken duren om volledig afbetaald te worden.");
            Console.ReadLine();
        }
    }
}
