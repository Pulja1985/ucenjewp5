namespace vježbanje1
{
    internal class VZ7
    {
        public static void Izvedi()
        {

            /*int[] ime = { 1, 2, 4, 5, 6, 7 };
            int[] prezime = new int[5];
            prezime[0] = 25;

            for (int i = 0; i < prezime.Length; i++)
            {


                Console.WriteLine(prezime[i]);
            }
            //Console.WriteLine(ime[2]);

            string[] name = { "1", "2", "3", "4", "5" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }*/



            //string y = Console.ReadLine();
            //Console.WriteLine(y);

            int[] z = new int[10];

            Console.WriteLine("Unesite 10 elemenata:");
            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine("Unesi element " + i + ".");
                int s = int.Parse(Console.ReadLine());
                z[i] = s;
            }
            Console.WriteLine("Unjeli ste");



            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine("Uneseni broj " + z[i]);
            }








        }



    }
}
