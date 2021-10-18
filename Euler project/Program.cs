using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 100000;
            int som = 0;

            for (int i = 0; i <= getal; i++)
            {
                if (i <= 0)
                {
                    //skip
                    continue;
                }

                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    som += i;

                    if (som >= 234168)
                    {
                        // Force end
                        break;
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Som: {som}");
            Console.ReadLine();
        }
    }
}
