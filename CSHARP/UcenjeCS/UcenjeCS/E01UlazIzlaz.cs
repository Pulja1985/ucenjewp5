using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {


        public static void izvedi()
        {


            Console.WriteLine("Hello");

            Console.Write( "Upiši svoje ime");

            string ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste" + ime);

            Console.WriteLine("unijeli ste {0} ", ime);



            Console.WriteLine("Unesi adresu");

            string adresa = Console.ReadLine();


            Console.WriteLine( "unesi grad");

            string grad=Console.ReadLine(); 



            Console.WriteLine(adresa);
            Console.WriteLine(grad);

            Console.WriteLine( "Upiši svoje prezime");

            string prezime = Console.ReadLine();

            Console.WriteLine( "Unešeno" + prezime);

            Console.WriteLine("unešeno {0}", prezime);



            Console.WriteLine("upiši naziv svog auta");

            string naziv = Console.ReadLine();

            Console.WriteLine("Dodao si ime {0}", naziv);



            Console.WriteLine("upiši naziv svog psa");

            string psa= Console.ReadLine();

            Console.WriteLine("ime psa je {0}", psa);








        }








    }
}
