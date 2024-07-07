namespace vježbanje1
{
    internal class VZ9Net
    {
        public static void Izvedi()
        {
            /*
            //tipovi podatak
            string phrase = "Giraffe Academy";// string je niz znakova
            char grade = 'A';// sadrzava jedan znak
            int age = 30;    //sadrzava cijele brojeve
            float ocjena = 4; //decimalni koji se skoro nikad ne koristi
            double gpa = 3.2;// srednje veliki decimalni broj imamo i "float" i "decimal"
            bool isMale = true;// govori samo true ili false
            Console.WriteLine("giraffe \nacademy"); //\n je da printas u drugu liniju sta je iza slova n
            Console.WriteLine("giraffe \"academy\""); // \" daje navodnike iza sebe

            string pharse = "giraffe academy";
            Console.WriteLine(pharse);
            Console.WriteLine(pharse.Length);//govori koliko ima znakova u tom stringu// https://www.youtube.com/watch?v=GhQdlIFylQ8 // stao na 2:20 sati
            Console.WriteLine(pharse.ToUpper());//pretvara sva slova u velika 
            Console.WriteLine(pharse.ToLower());//ToLower pretvara u mala
            Console.WriteLine(pharse.Contains("Academy"));//gleda dali sadrzava određenu rijec u sebi
            Console.WriteLine(pharse[2]);//ako stavis u kockaste zagrade 0 gleda koji je prvi znak,ako stavis broj dva gleda koji je treci znak krece od 0,1,2,3
            Console.WriteLine()*/
            /*
            Console.WriteLine(Math.Min(4 ,56));//ispisuje manji broj
            Console.WriteLine(Math.Max(4, 56));//ispisuje veci broj

            Console.Write("Enter your  name:");//ispisuje na istoj liniji
            string name = Console.ReadLine();
            Console.Write("Enter your Age:");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " You are " + age);
            Console.ReadLine();*/
            // jednostavan kalkulator
            /*
            Console.Write("Enter a number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();*/
            /*
            string color, pluralNoun, celebrity;
            Console.Write("enter color: ");
            color = Console.ReadLine();

            Console.Write("enter plural oun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("enter a celebrity: ");
            celebrity = Console.ReadLine();



            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun +" are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();*/

            /*
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };// nizovi
            string[] friends = new string[5];//prazan niz sa 5 elemanata slobodnih
            friends[0] = "Jim";//dodajem vrijednosti elementima u nizu
            friends[1] = "Kelly";//dodajem vrijednosti elementima u nizu
            Console.WriteLine(friends[1]);//pristupio elementu u nizu
            luckyNumbers[1] = 900;//mjenjam vrijednost elementa 2 u 900
            Console.WriteLine(luckyNumbers[1]);// ako hoces pristupit nekom elmrntu u nizu[] i unura pises broj,brojevi krecu od 0,1,2
            */

            /*
            bool isMale = false;
            bool isTall = false;
            if (isMale && isTall) // && end operator moraju oba dvije tvrdnje biti true inace je false,  || or operator pregledava oba dva ali samo jedan mora biti true da ispise true
            {
                Console.WriteLine("You are tall male");


            }else if (isMale && !isTall)
            {
                Console.WriteLine("you are short male");


            
            }else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");

            }else
            {
                Console.WriteLine("You are  not male and not tall ");

            }
            Console.ReadLine();*/


            // kalkulator
            /*
            Console.Write("Enter a number");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter operator");
            string op = Console.ReadLine();

            Console.Write("Enter another number");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == "¨-")
            {
                Console.WriteLine(num1 - num2);

            }
            else if(op == "/")
            {
                Console.WriteLine(num1 / num2);

            }
            else if( op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            Console.ReadLine();
            */

            /*
            int index = 1;  //while loop

            while (index<=5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();
            */

            /*
            string secretWord = "Honda";//while loop
            string quess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(quess!=secretWord && !outOfGuesses)
            {
                if (guessCount<guessLimit)
                {
                    Console.Write("Enter guess: ");
                    quess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
            
            Console.ReadLine();
            */


            try    //try catch loop
            {
                Console.Write("Enter a number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



       // https://www.youtube.com/watch?v=wxznTygnRfQ





        }
    }
}
