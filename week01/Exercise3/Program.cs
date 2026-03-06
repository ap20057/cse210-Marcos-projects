using System;
//Updates to this one also.
class Program
//Updates
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            //Generated a random number with the Random class.
            Random randomGenerator = new Random();
            int myMagicNumber = randomGenerator.Next(1, 101);
            //Variable to store the user's guesses.
            int userGuesses = -1;
            //While loop to get a cicle of guesses of the user.
            int guessCount = 0;

            while (userGuesses != myMagicNumber)
            {
                Console.Write("Your guess: ");
                userGuesses = int.Parse(Console.ReadLine());
                guessCount++;
                //if statements to warn the user as hint.
                if (userGuesses < myMagicNumber)
                {
                    Console.WriteLine("Too low! ");
                }
                else if (userGuesses > myMagicNumber)
                {
                    Console.WriteLine("Too high! ");
                }
                else
                {
                    Console.WriteLine("Congratulations, you guessed the number!");
                }
            }
            Console.WriteLine($"You guessed the number in: {guessCount} attempts.  ");
            Console.Write("Would you like to play one more time? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing! Goodbye! ");
    }
}