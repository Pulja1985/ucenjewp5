namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void izvedi()
        {

            Console.Write("Unesite broj godina koji imate");
            int godine = int.Parse(Console.ReadLine());

            if (godine >= 18)
            {
                Console.WriteLine("Punoljetan");
            }

            else
            {
                Console.WriteLine("Maloljetan");
            }

        }















    }
}
