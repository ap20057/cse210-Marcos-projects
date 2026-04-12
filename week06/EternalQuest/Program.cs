//Author: Marcos Alas

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Exit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.RecordEvent(); break;
                case "3": manager.ListGoals(); break;
                case "4": manager.DisplayScore(); break;
                case "5":
                    Console.Write("File: ");
                    manager.Save(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("File: ");
                    manager.Load(Console.ReadLine());
                    break;
                case "7": return;
            }
        }
    }
}