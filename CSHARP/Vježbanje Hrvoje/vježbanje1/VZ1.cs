using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ1
    {

        public static void Izvedi()
        {


            Console.WriteLine("Unesite prvi broj");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            int drugibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite treći broj");
            int trećibroj = int.Parse(Console.ReadLine());



            int najmanjibroj = prvibroj;

            if (drugibroj < najmanjibroj)
            {
                najmanjibroj = drugibroj;
            }

            if (trećibroj < najmanjibroj)
            {
                najmanjibroj = trećibroj;
            }

            Console.WriteLine("Najmanji broj je:" + najmanjibroj);

























        }
    }
}
