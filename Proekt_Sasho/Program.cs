using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_Sasho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* zavedenie, koeto vuvejda:
             * broi posetiteli
             * izbor na masa - pushachi ili nepushachi
             * izbor na salata
             * izbor na osnovno
             * izbor na desert
             * izbor na pitie - alkohol, bezalkoholno
             * nachin na plashtane */

            Console.WriteLine("Vuvedi broi posetiteli: ");
            int n = int.Parse(Console.ReadLine());

            string[] masa = new string[n];
            string[] salata = new string[n];
            string[] osnovno = new string[n];
            string[] desert = new string[n];
            string[] pitie = new string[n];
            string[] plashtane = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Kakva masa si izbirash? ");
                masa[i] = Console.ReadLine();
                Console.WriteLine("Kakva salata si izbirash? ");
                salata[i] = Console.ReadLine();
                Console.WriteLine("Kakvo osnovno si izbirash? ");
                osnovno[i] = Console.ReadLine();
                Console.WriteLine("Kakuv desert si izbirash? ");
                desert[i] = Console.ReadLine();
                Console.WriteLine("Kakvo pitie si izbirash? ");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("Kak shte platish? ");
                plashtane[i] = Console.ReadLine();
            }
            Console.WriteLine("");
        }
    }
}
