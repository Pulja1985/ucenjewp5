namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("* * * * ");


            for (int i = 0; i < 10; i = i + 1) //i++ ++i i+=1
            {
                Console.WriteLine("Osijek");

            }
            Console.WriteLine("****");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine("****");

            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine("****");

            Console.WriteLine(suma);
            Console.WriteLine("****");

            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("****");


            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("****");


            int brojOd = 120;
            int brojDo = 20;

            for (int i = brojOd; i > brojDo; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("****");

            int[] niz = { 2, 3, 2, 3, 4, 5, 4, 3 };

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    Console.WriteLine(niz[i]);
                }
            }
            Console.WriteLine("****");

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
            Console.WriteLine("****");
            //tablica množenja

            for (int i = 0; i < 10; i++)//napraviti tablicu da lijepo izgleda
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine((i + 1) * (j + 1) + "");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****");

            int ukupno = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 1 || i == 3)
                {
                    continue;
                }
                if (++ukupno > 5)
                {
                    break;
                }

                Console.WriteLine(i);





            }
            Console.WriteLine("****");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    goto labela;
                }
            }

        labela:
            Console.WriteLine("Hello");

            Console.WriteLine("****");

            for (int i = 0; i > -1; i++)
            {
                break;//loša beskonacna petlja
            }
            int broj = 0;


            for (; ; )
            {
                Console.Write("Unesi brojizmeđu 10 i 20: ");
                broj = int.Parse(Console.ReadLine());
                if (broj >= 10 && broj <= 20)
                {
                    break;
                }
                Console.WriteLine("Neispravan unos");


            }
            Console.WriteLine("Unijeli ste" + broj);

            Console.WriteLine("****");

            String ime1 = "Ana";
            char[] ime2 = { 'A', 'n', 'a', };

            for (int i = 0; i < ime2.Length; i++)
            {
                Console.Write(ime2[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < ime1.Length; i++)
            {
                Console.Write(ime1[i]);
            }











        }
    }
}
