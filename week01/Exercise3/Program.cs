using System;

class Program
{
    static void Main(string[] args)
    {
        String keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            //random number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            string userInput = "";
            int guess = 0;
            int guessCount = 0;
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                guessCount = guessCount + 1;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {guessCount} guesses to guess the secret number.");

            Console.Write("Do you want to keep playing? ");
            keepPlaying = Console.ReadLine();
        }
    }
}