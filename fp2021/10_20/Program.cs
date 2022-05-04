using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // suma Gauss

            // Gauss();
            // GaussV2();
            // Triunghi();
            // Ordonare3();
        }


        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>

        private static void Ordonare3()
        {
            int a, b, c;
            Console.WriteLine("Introduceti 3 numere intregi pe o singura linie a consolei separate printr-un spatiu");

            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            
            if (tokens.Length < 3)
            {
                Console.WriteLine("Nu s-au introdus 3 numere!");
                return;
            }

            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);   
            c = int.Parse(tokens[2]);

            // min = Math.Min(a, Math.Min(b,c)); 
            // max = Math.Max(a, Math.Max(b,c));

            int min, max, med; // minimul, maximul, medianul (cel din mijloc)
            min = a;
            if ( b < min)
            {
                min = b;
            }
            if ( c < min )
            {
                min = c;
            }

            max = a;
            if ( b > max)
            {
                max = b;
            }
            if ( c > max )
            {
                max = c;
            }

            med = a + b + c - min - max;

            Console.WriteLine($"{min}, {med}, {max}");
            

        }

        /// <summary>
        /// Se dau 2 numere naturale pozitive. Determinati daca cele 3 nr pot fi lungimile laturilor unui triunghi.
        /// Suma lungimilor oricaror 2 laturi trebuie sa fie mai mare decat lungimea celei de-a 3-a laturi.
        /// </summary>

        private static void Triunghi()
        {
            int a, b, c;
            Console.WriteLine("Introduceti 3 numere naturale pozitive. Cate unul pe o singura linie. ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            // Varianta I

            /*if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        Console.WriteLine($"{a}, {b}, {c} pot fi lungimile laturilor unui triunghi");
                    }
                    else
                    {
                        Console.WriteLine($"{a}, {b}, {c} NU pot fi lungimile laturilor unui triunghi");
                    }
                }
                else
                {
                    Console.WriteLine($"{a}, {b}, {c} NU pot fi lungimile laturilor unui triunghi");
                }
            }
            else
            {
                Console.WriteLine($"{a}, {b}, {c} NU pot fi lungimile laturilor unui triunghi");
            }*/



            // Varianta a II-a 

            /* bool ok = false;
             if (a + b > c)
             {
                 if (a + c > b)
                 {
                     if (b + c > a)
                     {
                         ok = true;
                     }
                 }
             }
             if (ok)
             {
                 Console.WriteLine($"{a}, {b}, {c} pot fi lungimile laturilor unui triunghi");
             }
             else
             {
                 Console.WriteLine($"{a}, {b}, {c} NU pot fi lungimile laturilor unui triunghi");
             }
            */

            // Varianta a III-a

           /* if (a + b > c && a + c > b && b + c > a) // Snippet: Ctrl + K + F (pentru ce ai selectat) ori Ctrl + K + D (pentru tot documentul)
            {
                Console.WriteLine($"{a}, {b}, {c} pot fi lungimile laturilor unui triunghi");
            }
            else
            {
                Console.WriteLine($"{a}, {b}, {c} NU pot fi lungimile laturilor unui triunghi");
            }*/

            // Varianta a IV-a 
            // TODO: codul sa fie scris mai compact





        }







        /// <summary>
        /// Calculeaza Suma numerlor de la 1 la n (IN MOD EFICIENT)
        /// </summary>
        /// <example>
        /// pentru n = 5, S = 1 + 2 + 3 + 4 + 5 = 15
        /// </example>


        private static void GaussV2()
        {
            // S = 1 + 2 + 3 + ... + n
            // S = n + ( n - 1 ) + ... + 1
            // 2S = (n + 1) + (n + 1)+..+(n+1) = n*(n+1)
            // S = n*(n+1)/2
            int suma = 0;
            int n;
            Console.Write("Introduceti un numar natural: ");
            n = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Suma numerelor de la 1 la {n} este: {n * ( n + 1 ) / 2}"); ---> pusca la 47000 

            // SAU --- > o varianta mai buna 

            if (n % 2 == 0)
            {
                suma = n / 2 * (n + 1);
            }
            else
            {
                suma = (n + 1) / 2 * n;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
        }


        /// <summary>
        /// Calculeaza Suma numerlor de la 1 la n
        /// </summary>
        /// <example>
        /// pentru n = 5, S = 1 + 2 + 3 + 4 + 5 = 15
        /// </example>


        private static void Gauss()
        {
            int suma = 0;
            int n;
            Console.Write("Introduceti un numar natural: ");
            n = int.Parse(Console.ReadLine());


            try
            {
                for (int i = 0; i <= n; i++)
                {

                    checked
                    {
                        suma = suma + i;
                    }

                }
                Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
