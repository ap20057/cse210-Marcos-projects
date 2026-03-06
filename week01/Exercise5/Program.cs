using System;
//updates for exercise 5 also for resubmission. 
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, SquaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to this program! ");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }
}
