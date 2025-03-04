/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slovicka = { "opice", "kočka", "pes", "ryba", "kůň"};
            string[] preklady = { "monkey", "cat", "dog", "fish", "horse"};
            int[] poradi = new int[slovicka.Length];
            int uspesnost = 0;
            for (int i = 0; i < poradi.Length; i++)
            {
                poradi[i] = i;
            }
            Random r = new Random();
            for (int i = 0;i < slovicka.Length; i++)
            {
                int nahodneCislo = r.Next(slovicka.Length);
                int pomocnaPromenna = poradi[nahodneCislo];
                poradi[nahodneCislo] = poradi[i];
                poradi[i] = pomocnaPromenna;
            }

            for (int i = 0; i < slovicka.Length; i++)
            {
                Console.WriteLine("Kvíz - přelož do angličtiny:");
                Console.WriteLine($"{slovicka[poradi[i]]}");
                string odpoved = Console.ReadLine();
                if (odpoved == preklady[poradi[i]])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("správně");
                    Console.ForegroundColor = ConsoleColor.White;
                    uspesnost++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("chyba");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Tvoje úspěšnost: {uspesnost}/{slovicka.Length}");
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraceniZlomku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte čitatel zlomku: ");
            long citatel = long.Parse(Console.ReadLine());
            Console.Write("Zadejte jmenovatel zlomku: ");
            long jmenovatel = long.Parse(Console.ReadLine());
            long mensi;

            if (citatel > jmenovatel)
                mensi = jmenovatel;
            else
                mensi = citatel;

            for (long i = mensi; i > 1; i--)
            {
                bool deleniCitatele = ((citatel / i) == ((double)citatel / i));
                bool deleniJmenovatele = ((jmenovatel / i) == ((double)jmenovatel / i));
                if (deleniCitatele & deleniJmenovatele)
                {
                    citatel = citatel / i;
                    jmenovatel = jmenovatel / i;
                }
            }
            Console.WriteLine("Zkrácený zlomek je: {0}/{1}", citatel, jmenovatel);

            Console.ReadKey();
        }
    }
}
