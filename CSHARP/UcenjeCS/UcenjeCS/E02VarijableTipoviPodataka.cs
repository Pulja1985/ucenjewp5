namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {



        public static void Izvedi()
        {

            int i;


            i = 7;


            Console.WriteLine(i);

            Console.Write("Molim upisati cijeli broj veći od nule: ");

            int broj = int.Parse(Console.ReadLine());


            Console.WriteLine(broj + 1);

            Console.WriteLine(broj + 2);

            Console.Write("Unesi decimalni broj(, je oznaka za decimalni broj): ");

            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);



            bool uvijet = false;

            Console.WriteLine(uvijet);


            int j = 3;

            Console.WriteLine(j == 3);
            Console.WriteLine(j != 6);

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



            int x = 0, y = 1;
            x = ++x - y;
            y = x-- + y;
            Console.WriteLine(x + y);





            Console.WriteLine("9%2={0}", 9 % 2);
            Console.WriteLine("8%2={0}", 8 % 2);


            x = 5;
            y = 2;

            Console.WriteLine(x / (float)y); ;


            int c = 2, d = 3;
            c = --c + d;//4
            d = c++ - d;//2
            Console.WriteLine(c + d);//6


            int e = 1, f = 2;
            e = ++e + f;//4
            f = e-- - f;//1
            Console.WriteLine(e + f);//5

            int g = 3, h = 4;
            g = ++g + h;//8
            h = ++h + g;//13
            Console.WriteLine(g + h);//21


            int k = 2, l = 3;
            k = ++k - l;//0
            l = k-- + l;//2
            Console.WriteLine(k + l);//2


































        }



















    }
}
