namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            int temp1, temp2, temp3, temp4;//ovo je loše


            int[] temperature = new int[12];

            temperature[0] = -2;
            temperature[1] = 0;
            temperature[2] = 3;
            temperature[3] = 4;
            temperature[4] = 7;
            temperature[5] = 19;
            temperature[6] = 28;
            temperature[7] = 31;
            temperature[8] = 28;
            temperature[9] = 18;
            temperature[10] = 11;
            temperature[11] = 5;

            Console.WriteLine(temperature.Length);

            temperature[temperature.Length - 1] = 0;
            Console.WriteLine(temperature[3]);

            Console.WriteLine(temperature);

            Console.WriteLine(string.Join(",", temperature));

            int[] niz = { 2, 3, 4, 5, 56, 6, 3, 3 };

            Console.WriteLine(niz[4]);



            string[] gradovi = { "Osijek", "Donji Miholjac", "Vinkovci", "Belišće" };

            Console.WriteLine(gradovi[gradovi.Length - 1]);

            int[,] tablica = {
            {1,2,3 },
            {4,5,6},
            {7,8,9}
            };

            Console.WriteLine(tablica[1, 2]);
            Console.WriteLine(tablica[2, 2]);

            int[,,] kocka = { };//trodimenzionalni niz
            int[,,,] tesarect = { };// tesarect - 4 dimenzije
            int[,,,,,,] multiverse = { };// multiverse

            //razliciti tipovi podataka u nizu
            object[] objekti = { "ovo", "3", "2,6", "true" };


















        }
    }
}
