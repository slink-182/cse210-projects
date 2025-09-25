using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Hello Prep5 World!");

    //     //call methods
    //     DisplayMessage(args);
    // }

    // static void DisplayMessage(string[] args)
    // {
    //     Console.WriteLine("This is an example of a string in a method.");
    // }

    // static void TestPassByValue(int x)
    // {
    //     x = 99;
    //     //example 1
    // }
    // public static void Main_2(string[] args)
    // {
    //     int x = 10;
    //     TestPassByValue(x);
    //     Console.WriteLine(x);
    //     //example 2
    // }

    static void Main(string[] args)
    {
        // 1. Display welcome message
        DisplayWelcome();

        // 2. Ask for user's name
        string userName = PromptUserName();

        // 3. Ask for user's favorite number
        int favoriteNumber = PromptUserNumber();

        // 4. Ask for user's birth year using out parameter
        int birthYear;
        PromptUserBirthYear(out birthYear);

        // 5. Square the favorite number
        int squaredNumber = SquareNumber(favoriteNumber);

        // 6. Display the result
        DisplayResult(userName, squaredNumber, birthYear);
    }

    // 1. Display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // 2. Prompt user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // 3. Prompt user for favorite number and return it as int
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input); 
        return number;
    }

    // 4. Prompt user for birth year using out parameter
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Enter your birth year: ");
        string input = Console.ReadLine();
        year = int.Parse(input); 
    }

    // 5. Square a number and return the result
    static int SquareNumber(int num)
    {
        return num * num;
    }

    // 6. Display results
    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"\nHello, {name}!");
        Console.WriteLine($"Your favorite number squared is: {squaredNumber}");
        Console.WriteLine($"You will turn {age} years old this year.");
    }
}


//notes --
//the fact that the assignment makes us use so many 
//methods /(functions in python) is ridiculous
