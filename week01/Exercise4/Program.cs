using System;
using System.Collections.Generic;
//updates for exercise 4 also on new cloned repository.

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumbers = -1;
        while (userNumbers != 0)
        {
            Console.Write("Type any number (0 to stop): ");
            string userAnswer = Console.ReadLine();
            userNumbers = int.Parse(userAnswer);
            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"This sum is: {sum}. ");
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}. ");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}. ");
    }
}