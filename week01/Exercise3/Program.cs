using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.")
        bool playAgain = true;

        while (playAgain)
        {
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int myGuess = -1;
            int attempts = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            
            while (myGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out myGuess))
                {
                    attempts++; 

                    if (magicNumber > myGuess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (magicNumber < myGuess)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
