using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {


        public static void Izvedi()
        {
            Console.Write("Unesite ocjenu(od 1 do 5):");
            string ocjena = Console.ReadLine();

            bool  isnumeric=int.TryParse(ocjena, out int o);

            if (isnumeric && o >= 1 && o <= 5)
            {

                string Ocjenauslovima;
                switch(o)
                {
                    case 1:
                        Ocjenauslovima = "Nedovoljan";
                        break;

                    case 2:
                        Ocjenauslovima = "Dovoljan";
                        break;
                    case 3:
                        Ocjenauslovima = "Dobar";
                        break;
                    case 4:
                        Ocjenauslovima = "Vrlo Dobar";
                        break;
                    case 5:
                        Ocjenauslovima = "Odičan";
                        break;


                }

                Console.WriteLine("ocjena u slovima je:" );
                Console.WriteLine("Broj nije ocijena");
            }

            
          

            





        }
    }
}
