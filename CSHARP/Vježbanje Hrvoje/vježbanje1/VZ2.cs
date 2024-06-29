using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ2
    {



        public static void Izvedi()
        {
            Console.WriteLine("Unesite prvi broj");
            int prviboj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            int drugibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite treci broj");
            int trecibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite cetvrti brojj");
            int cetvrtibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite petibroj");
            int petibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite sesti broj");
            int sestibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("unesite sedmi broj");
            int sedmibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osmi broj");
            int osmibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("unesite deveti broj");
            int devetibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite deseti broj");
            int desetibroj = int.Parse(Console.ReadLine());

            int najmanjibroj = prviboj;

            if (drugibroj < najmanjibroj)
            {
                najmanjibroj = drugibroj;
            }
            if (trecibroj < najmanjibroj)
            {
                najmanjibroj = trecibroj;
            }
            if (cetvrtibroj < najmanjibroj)
            {
                najmanjibroj = cetvrtibroj;
            }
            if (petibroj < najmanjibroj)
            {
                najmanjibroj = petibroj;
            }
            if (sestibroj < najmanjibroj)
            {
                najmanjibroj = sestibroj;
            }
            if (sedmibroj < najmanjibroj)
            {
                najmanjibroj = sedmibroj;
            }
            if (osmibroj < najmanjibroj)
            {
                najmanjibroj= osmibroj;
            }
            if (devetibroj < najmanjibroj)
            {
                najmanjibroj = devetibroj;
            }
            if (desetibroj < najmanjibroj)
            {
                najmanjibroj = desetibroj;
            }

            Console.WriteLine("najmanji broj je:" + najmanjibroj);

        }
    }
}
