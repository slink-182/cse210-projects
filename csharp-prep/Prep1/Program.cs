using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // assignment p1
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        //the shorter way looks better to me than the long form
        // Console.WriteLine("the name is " + lastname + ", " + firstname + " " + lastname + ".");
        Console.WriteLine($"The name is {lastname}, {firstname} {lastname}.");
    }
}