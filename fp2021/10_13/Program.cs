using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            problema1();
        }

        /// <summary>
        /// Metoda calculeaza suma numerelor de la 1 la n 
        /// </summary>
        /// <examnple>
        /// pentru n = 3 metoda calculeaza 1 + 2 + 3 care este egal cu 6 si afiseaza rezultatul 
        /// </examnple>

        private static void problema1() // p1 method 
        {
            int numar;



            // identificatori formati dintr-o singura litera nu sunt recomandati 
            int m, k, l, s, aux, lin, col;
            // obs: numele identificatorilor trebuie sa sugereze rolul lor. 
            // in general numele identificatorilor vor fi cuvinte sau combinatii de cuvinte
            // luate din spatiu problemei
            // Exemple
            int suma, linie, coloana, contor, maximumCapacity, length; 


            numar = int.Parse(Console.ReadLine()); /// ?? tratarea exceptiilor 

            int i = 0;

            try
            {
                suma = 0;
                i = 1;
                while (i <= numar) // snippet: scriem while + Tab + Tab 
                {
                    checked // snippet: select the line of code -> snippet -> ctrl+k ctrl+s (surround with) -> chose (try - catch block / checked block..)
                    {
                        suma = suma + i; 
                    }
                    i = i + 1; 
                }

                Console.WriteLine($"Suma numerelor de la 1 la {numar} este {suma}");
            }
            catch (Exception e)
            {

                Console.WriteLine($"pentru i = {i} {e.Message}");
            }
        }
    }
}
