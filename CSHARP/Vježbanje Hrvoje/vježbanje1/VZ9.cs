using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbanje1
{
    internal class VZ9
    {
        public static void Izvedi()
        {


            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            float ocjena = 4; //decimalni koji se skoro nikad ne koristi
            double gpa = 3.2;// srednje veliki decimalni broj
            bool isMale = true;
            Console.WriteLine("giraffe \nacademy"); //\n je da printas u drugu liniju sta je iza slova n
            Console.WriteLine("giraffe \"academy\""); // " daje navodnike iza sebe

            string pharse = "giraffe academy";
            Console.WriteLine(pharse);
            Console.WriteLine(pharse.Length);//govori koliko ima znakova u tom stringu
            Console.WriteLine(pharse.ToUpper());//pretvara sva slova u velika 
            Console.WriteLine(pharse.ToLower());//ToLower pretvara u mala
            Console.WriteLine(pharse.Contains("Academy"));//gleda dali sadrzava određenu rijec u sebi
            Console.WriteLine(pharse[2]);//ako stavis u kockaste zagrade 0 gleda koji je prvi znak,ako stavis broj dva gleda koji je treci znak krece od 0,1,2,3



        }
    }
}
