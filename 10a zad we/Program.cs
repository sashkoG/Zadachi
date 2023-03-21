using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10a_zad_we
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Kolko produkti shte vuvejdash(1-10)? ");
            int n = int.Parse(Console.ReadLine());

            string[] stoka = new string[n];
            double[] gramaj = new double[n];
            double[] trainost = new double[n];

            do
            {
               
                    Console.WriteLine("Izvun uslovieto si");
                
            }
            while (n <= 1 && n >= 10);
            
             for (int i = 0; i < n; i++)
             {
                Console.WriteLine("Napishi stokata #{0}: ", i+1);
                stoka[i] = Console.ReadLine();

                Console.WriteLine("Napishi gramaja na stokata: ");
                gramaj[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Napishi trainost v dni: ");
                trainost[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Produkt #{0}: {1}", stoka[i]);
                Console.WriteLine("Gramaj: {0} g", gramaj[i]);
                Console.WriteLine("Trainost: {0} dni", trainost[i]);
             }
   
            

            
            
        }
    }

}
    

