using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeem_informatie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is64bit = Environment.Is64BitOperatingSystem;
            string pcname = Environment.MachineName;
            int proccount = Environment.ProcessorCount;
            string username = Environment.UserName;
            long memory = Environment.WorkingSet; //zal ongeveer 10 Mb teruggeven.
                                                  //  memory = Console.ReadLine();

            Console.WriteLine($"pcname: {pcname}\nProcessor Count: {proccount}\nUsername: {username}\nMemory: {memory * 0.000001} MB\n64Bit: {is64bit}");
            Console.ReadLine();
        }
    }
}
