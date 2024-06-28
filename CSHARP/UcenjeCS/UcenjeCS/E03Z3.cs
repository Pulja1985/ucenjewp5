using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {

        public static void Izvedi()
        {

            Console.Write("Unesi prvi broj");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj");
            int drugibroj = int.Parse(Console.ReadLine());


            int manjibroj;
            if (prvibroj < drugibroj)
            {
                manjibroj = prvibroj;
            }

            else
            {
                manjibroj = drugibroj;

            }

            Console.WriteLine("ispisi manji broj" + manjibroj);




















        }

















    }
}
