using System;
//resubmission of the exercise one.
class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name and last name...
        Console.WriteLine("Hello 2026 CSE-210!. ");
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}. ");
    }
}

