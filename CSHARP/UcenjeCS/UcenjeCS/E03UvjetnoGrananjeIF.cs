namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIF
    {

        public static void Izvedi()
        {

            int i = 7;

            bool uvijet = i == 8;

            Console.WriteLine(uvijet);


            // if radi s bool tipom podataka
            if (uvijet)
            {
                Console.WriteLine("Vrijednost varijable i je 8");
            }


            //ovo nikada ne pisati
            if (uvijet == true)
            {

            }


            // najčešća sintaksa
            if (i == 8)
            {

            }

            // if ima i else granu

            if (i > 10)
            {
                Console.WriteLine("i je veći od 10");
            }

            else
            {
                Console.WriteLine("i nije veći od 10");
            }

            // if ne mora imati{} ako if or else odnose na samo jednu liniju
            // ovo nije najbolja praksa.Best practice

            if (i > 10)
                Console.WriteLine("i je veći od 10");

            else
                Console.WriteLine("i nije veći od 10");
            Console.WriteLine("AAAAA");

            //puna sintaksa if naredbe

            int b = 2;
            if (b == 1)
            {
                Console.WriteLine("Ne može");
            }

            else if (b > 5)
            {
                Console.WriteLine("OK");

            }

            // ili moze ici nn else if djelova

            else
            {
                Console.WriteLine("Ostalo");

            }


            //operatori & i &&
            // & uvijek provjerava oba uvijeta
            // && ukoliko 1. uvijet nije zadovoljen, drugi se  niti ne gleda

            int x = 2, Y = 1;

            if (x == 1 && Y == 1)
            {
                Console.WriteLine("x i y su i");
            }



            // operatori | i ||

            // | provjerava oba uvijeta
            // || ukoliko je prvi uvijet zadovoljen, ne gleda se drugi


            if (x > 1 || Y == 0)
            {
                Console.WriteLine("ako je prvi uvjet zadovoljen ulazi se u if");
            }

            // if se moze gnjezditi
            if (x == 3)
            {
                int k = 9;
                if (i > 0)
                {
                    Console.WriteLine("Zadovoljeno");
                }
            }

            // inline if - tercijalni  operator  ? :

            x = 0;
            if (i > 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NE");
            }

            //preduvijet je da if i else provode istu akciju - u ovom slučaju cw

            Console.WriteLine(x == 0 ? "OK" : "NE");













        }

















    }
}
