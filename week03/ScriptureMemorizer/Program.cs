// Author: Marcos Alas


using System;

class Program
{
    static void Main()
    {
        // scripture (Proverbs 3:5-6)
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all your heart and lean not on your own understanding; " +
            "in all your ways submit to him, and he will make your paths straight...");


        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
                break;

            Console.WriteLine("Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Program ended.");
        Console.WriteLine();

        
         
        /* 

        Creativity:
        1. Randomly hides only non-hidden expressions.
        2. Can handle scriptures with multiple verses (e.g., Proverbs 3:5-6).
       
        */
    }
}