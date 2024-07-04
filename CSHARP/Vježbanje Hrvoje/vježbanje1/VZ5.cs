using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ5
    {

        public static void Izvedi()
        {
            int[,] tablica = {
                { 1, 2, 30 },//6 i 9 moraju biti ispod 0 na broju 30
                
            { 4, 5, 6 },

            { 7, 8, 9 }

            };

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + "");
                }
                Console.WriteLine();
            }

            tablica[1, 2] = tablica[1, 2];








 
        }
    }
}
