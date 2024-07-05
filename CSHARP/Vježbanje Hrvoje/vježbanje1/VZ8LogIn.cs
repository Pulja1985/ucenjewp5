using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ8LogIn
    {
        public static void Izvedi()
        {
            string pravoIme = "Hrvoje";
            string praviPassword = "1234";

            



            Console.WriteLine("Unesi korisničko ime");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi password");
            string password = Console.ReadLine();

            if (pravoIme == ime && praviPassword == password)
            {
                Console.WriteLine("Uspješno ste ulogirani");
            }
            else
            {
                Console.WriteLine("pogršan username ili password");
            }
            
            
                
            





        }



    }
}
