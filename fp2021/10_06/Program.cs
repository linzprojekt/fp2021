using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// useful shortcuts: Ctrl + K + C

namespace _10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World. Today is {DateTime.Now}"); // sintaxa recomandata

            Console.WriteLine("Hello World. Today is {0}", DateTime.Now); // sintaxa "invechita"

            Console.WriteLine("Hello World. Today is " + DateTime.Now); // a III-a varianta 

            Console.WriteLine("Introduceti un numar:");

            int n; // Q: Ce este o variabila -> este un nume pentru o locatie in memorie

            Console.WriteLine($"Cea mai mare valoare care se poate stoca pe int este {int.MaxValue}");
            Console.WriteLine($"Cea mai mica valoare care se poate stoca pe int este {int.MinValue}");
            Console.WriteLine($"Numarul total de valori care se poate stoca pe int este {1L + int.MaxValue - int.MinValue}"); // {(long)int.MaxValue - int.MinValue + 1}

            // int se stocheaza pe 32 biti
            // short (16 biti), long (64 biti), byte (8 biti), uint (32 biti, u = unsigned), ushort (16 biti), sbyte (8 biti), ulong (64 biti)


            // FP - C1 Oros min 1h / 1hh44min
        }
    }
}
 