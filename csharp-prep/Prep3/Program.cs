using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            
            while (guess != magicNumber)
            {
                
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                
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
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower() == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }
}
