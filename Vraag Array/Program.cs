using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_Array
{
    class Program
    {
        // TODO: Een get methode hoort een resultaat terug te geven.
        // TODO: Deze methode doet meer dan 1 ding. -> Opsplitsen.
        public static void GetResult()
        {
            string[] vragen = { "Geboortedag?", "Geboortemaand?", "Geboortejaar?", "Geluksgetal?", "Getal tussen 1 en 10?", "Ongeluksgetal?" };
            int[] antwoorden = new int[6];

            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]}");
                antwoorden[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            // TODO: Kan je de code herschrijven zodat er geen ?- tekens getoond worden bij het printen van het resutaat?
            for (int i = 0; i < antwoorden.Length; i++)
            {
                Console.WriteLine($"{vragen[i]} = {antwoorden[i]}");
            }

        }
        static void Main(string[] args)
        {
            GetResult();
            Console.ReadLine();
        }
    }
}
