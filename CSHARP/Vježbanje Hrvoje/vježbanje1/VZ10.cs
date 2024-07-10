namespace vježbanje1
{
    internal class VZ10
    {
        public static void Izvedi()
        {
            // POGAĐANJE BROJEVA
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between 1 and 100 : ");
                    guess = int.Parse(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high ");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low ");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win");
                Console.WriteLine("Guesses:" + guesses);
                Console.WriteLine("Would you like to play again(Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }



            }
            Console.WriteLine("Thanks for playing!!");
        }
    }
}
