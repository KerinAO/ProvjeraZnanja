using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 0, broj1 = 0, brojac = 0;

            Console.WriteLine("Unesite 3 dvoznamenkasta broja: ");
            do
            {
                broj1 = Convert.ToInt32(Console.ReadLine());
                if (broj1 < 10)
                {
                    Console.WriteLine("Unesite dvoznamenkasti broj!");
                }
                else if (broj1 > 99)
                {
                    Console.WriteLine("Unesite dvoznamenkasti broj!");
                }
                else
                {
                    broj1 += broj;
                    brojac++;
                }
            } while (brojac < 3);
            
            
        
            Console.ReadKey();  
        }
    }
}
