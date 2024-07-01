using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ4
    {
        public static void Izvedi()
        {
            Console.Write("Unesite cjeli broj:");
            string input = Console.ReadLine();
            int broj;

            if (int.TryParse(input, out broj))
            {
                if (broj %2 == 0)
                {
                    Console.WriteLine("Broj je paran");
                }
                else
                {
                    Console.WriteLine("Broj je neparan");
                }
            }
            else
            {
                Console.WriteLine("Uneseni broj nije cijeli broj");
            }

            
        }







    }
}
