﻿namespace UcenjeCS
{
    internal class E09ForeachPetlja
    {


        public static void Izvedi()
        {

            string grad = "Osijek";
            for (int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }


            foreach (char znak in grad)
            {
                Console.WriteLine(znak);
            }

            int broj = 5844;//ovo 

            // ovo ne može
            // foreach(int b in broj)
            // {
            //     Console.WriteLine(b);
            //  }


            float[] brojevi = { 2, 3, 4, 5.3f, 3, 3, 2, 2 };
            float suma = 0;
            foreach (var e in brojevi)
            {
                Console.WriteLine(e);
                suma += e;
            }
            Console.WriteLine(suma);










        }
    }
}
