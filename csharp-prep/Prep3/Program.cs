using System;

class Program
{
    static void Main(string[] args)
    {
        // Constants & Variables
        string response = "yes";
        int trying = 0;
        int intGuessNumber = 0; // Declare intGuessNumber outside the loop
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        // Early Calculations
        do
        {
            Console.Write("What is your guess? ");
            response = Console.ReadLine();
            intGuessNumber = int.Parse(response);  // Assign value inside the loop
            
            trying += 1;

            // Sign calculation
            if (intGuessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (intGuessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it in {trying} tries!");// Stretch Challenge, Keep track of how many 
                                                                        // guesses the user has made and inform them 
                                                                        // of it at the end of the game.
            }

        } while (intGuessNumber != magicNumber); // Condition to continue the loop
    }
}