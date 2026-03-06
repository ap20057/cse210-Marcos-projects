using System;
//updates for resubmission.
// Start asking the grade to the user and show the letter of this one.
/* 
 Project: Grades Calculator in C#. 
 Author: Brother Marcos Alas. 
 Purpose: Use of variables, if statements and other elements learned for c#.
 */
class Program
{
    static void Main(string[] args)
    {
        //Here is for the grade provided by the user.
        Console.Write("Please type your grade: ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        //Variable for the letter of the grade.
        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        //adding sign + or - to the letter grade.
        string sign = "";
        int lastDigit = gradeNumber % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradeNumber >= 93)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}. ");
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, Welcome to the champions team! ");
        }
        else
        {
            Console.WriteLine("Work harder to get it next time! ");
        }
    }
}