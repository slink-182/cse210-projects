using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        //assignment p2
        Console.Write("Enter your numeric grade (0-100): ");

        string grade_str = Console.ReadLine();
        int grade = int.Parse(grade_str);
        string letter_grade = null;

        //all "if" and "else if" statements to sort letter grade from int
        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else if (grade < 60)
        {
            letter_grade = "F";
        }

        //print letter grade to the terminal<3
        Console.WriteLine($"Your letter grade is {letter_grade}.");
    }
}

//I had to add null to the original declaration of the variable letter_grade as the compiler(I believe) wasn't having it. It wanted it defined.

