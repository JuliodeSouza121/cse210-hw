using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        string gradeLetter = "";

        if (gradeNumber >= 93)
        {
            gradeLetter = "A";
        }

        else if (gradeNumber >= 90)
        {
            gradeLetter = "A-";
        }

        else if (gradeNumber >= 87)
        {
            gradeLetter = "B+";
        }
        else if (gradeNumber > 83 && gradeNumber < 87)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B-";
        }
        else if (gradeNumber >= 77)
        {
            gradeLetter = "C+";
        }
        else if (gradeNumber > 73 && gradeNumber < 77)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C-";
        }
        else if (gradeNumber >= 77)
        {
            gradeLetter = "D+";
        }
        else if (gradeNumber > 63 && gradeNumber < 67)
        {
            gradeLetter = "D";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D-";
        }
        else
        {
            gradeLetter = "F";
        }
        
        Console.WriteLine($"Your grade is {gradeLetter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, You don't achieve the minimum grade value.");
        }
    }
}