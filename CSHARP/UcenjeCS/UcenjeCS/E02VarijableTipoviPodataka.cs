using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {



        public static void Izvedi()
        {

            int i;


            i=7; 


            Console.WriteLine(i);

            Console.Write("Molim upisati cijeli broj veći od nule: ");

            int broj = int.Parse(Console.ReadLine());


            Console.WriteLine(broj + 1);

            Console.WriteLine(broj + 2);

            Console.Write("Unesi decimalni broj(, je oznaka za decimalni broj): " );

            Console.WriteLine(float.Parse (Console.ReadLine())+1);



            bool uvijet = false;

            Console.WriteLine(uvijet);


            int j = 3;

            Console.WriteLine(j == 3);
            Console.WriteLine(j!=6);

            i = 0;
            i = i + 1;
            i += 1;
            i++;
            ++i;

            i = 1;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);
            Console.WriteLine(i);

            i--;
            --i;



            int x = 0, y=1;
            x = ++x - y;
            y = x-- + y;
            Console.WriteLine( x+y);





            Console.WriteLine("9%2={0}", 9 % 2);
            Console.WriteLine("8%2={0}", 8 % 2);


            x = 5;
            y = 2;

            Console.WriteLine(x / (float)y); ;


































        }



















    }
}
