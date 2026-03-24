
/*Author: Marcos Alas
Project: Journal app*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry(prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename (example: myJournal.txt): ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename (example: myJournal.txt): ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye 👋");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}