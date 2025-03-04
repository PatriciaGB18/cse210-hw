using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes"; 

        while (playAgain.ToLower() == "yes") 
        {
            Random rand = new Random();
            int magicNumber = rand.Next(1, 101); 
            int guess = -1; 
            int guessCount = 0; 
            

            Console.WriteLine("I have selected a magic number between 1 and 100. Try to guess it!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine(); 

                if (int.TryParse(input, out guess)) 
                {
                    guessCount++;

                    if (guess == magicNumber)
                    {
                        Console.WriteLine("You are correct!");
                        Console.WriteLine("It took you " + guessCount + " guesses.");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("Higher");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
