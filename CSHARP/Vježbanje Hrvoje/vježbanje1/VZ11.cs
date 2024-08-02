using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ11
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite dužinu lozinke:");
            int duzinaLozinke = int.Parse(Console.ReadLine());

            Console.WriteLine("Uključiti velika slova? (da/ne):");
            bool ukljuciVelikaSlova = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Uključiti mala slova? (da/ne):");
            bool ukljuciMalaSlova = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Uključiti brojeve? (da/ne):");
            bool ukljuciBrojeve = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Uključiti interpunkcijske znakove? (da/ne):");
            bool ukljuciInterpunkcijske = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka počinje s brojem? (da/ne):");
            bool pocinjeBrojem = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka počinje s interpunkcijskim znakom? (da/ne):");
            bool pocinjeInterpunkcijskim = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka završava s brojem? (da/ne):");
            bool zavrsavaBrojem = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka završava s interpunkcijskim znakom? (da/ne):");
            bool zavrsavaInterpunkcijskim = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka nema ponavljajuće znakove? (da/ne):");
            bool bezPonavljanja = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Broj lozinki koje je potrebno generirati:");
            int brojLozinki = int.Parse(Console.ReadLine());

            // Generiranje lozinki
            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(
                    duzinaLozinke,
                    ukljuciVelikaSlova,
                    ukljuciMalaSlova,
                    ukljuciBrojeve,
                    ukljuciInterpunkcijske,
                    pocinjeBrojem,
                    pocinjeInterpunkcijskim,
                    zavrsavaBrojem,
                    zavrsavaInterpunkcijskim,
                    bezPonavljanja);

                Console.WriteLine($"Lozinka {i + 1}: {lozinka}");
            }
        }

        static string GenerirajLozinku(int duzina, bool velikaSlova, bool malaSlova, bool brojevi, bool interpunkcija, bool pocinjeBrojem, bool pocinjeInterpunkcijskim, bool zavrsavaBrojem, bool zavrsavaInterpunkcijskim, bool bezPonavljanja)
        {
            string velikaSlovaSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSlovaSet = "abcdefghijklmnopqrstuvwxyz";
            string brojeviSet = "0123456789";
            string interpunkcijaSet = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";

            StringBuilder karakteri = new StringBuilder();

            if (velikaSlova) karakteri.Append(velikaSlovaSet);
            if (malaSlova) karakteri.Append(malaSlovaSet);
            if (brojevi) karakteri.Append(brojeviSet);
            if (interpunkcija) karakteri.Append(interpunkcijaSet);

            Random random = new Random();
            StringBuilder lozinka = new StringBuilder();
            char prethodniKarakter = '\0';

            if (pocinjeBrojem)
            {
                lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
            }
            else if (pocinjeInterpunkcijskim)
            {
                lozinka.Append(interpunkcijaSet[random.Next(interpunkcijaSet.Length)]);
            }
            else
            {
                lozinka.Append(karakteri[random.Next(karakteri.Length)]);
            }

            for (int i = lozinka.Length; i < duzina - 1; i++)
            {
                char noviKarakter;
                do
                {
                    noviKarakter = karakteri[random.Next(karakteri.Length)];
                } while (bezPonavljanja && noviKarakter == prethodniKarakter);

                lozinka.Append(noviKarakter);
                prethodniKarakter = noviKarakter;
            }

            if (zavrsavaBrojem)
            {
                lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
            }
            else if (zavrsavaInterpunkcijskim)
            {
                lozinka.Append(interpunkcijaSet[random.Next(interpunkcijaSet.Length)]);
            }
            else
            {
                lozinka.Append(karakteri[random.Next(karakteri.Length)]);
            }

            return lozinka.ToString();
        }
    }
}
