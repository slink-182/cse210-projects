using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        //while loop --
        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        //do-while loop --
        // string response;
        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        //for loop --
        // for (int i = 0; i < 10; i++) //sets "i" as 0. sets condition that if "i" is less than 10, add 1 to "i"
        // {
        //     Console.WriteLine(i); //prints "i"
        // }

        //foreach loop
        // List<string> colors = new List<string> { "red", "orange", "yellow", "green" };
        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        //random numbers
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        //prep project 3 --
        //to do: add boolean switch variable to turn on and off the while loop for if you have the right number<3
        bool loop_it = true; //set boolean to true
        Random randomGenerator = new Random(); //generate random number
        int random_number = randomGenerator.Next(0, 101); //store the random number

        while (loop_it == true) //True enables while loop
        {
            Console.Write("Guess a number: "); //print prompt
            string input = Console.ReadLine(); //store input
            int guessed_number = int.Parse(input); //convert variable from string to int
            if (guessed_number == random_number) //guessed number matches random number. It was correct!
            {
                Console.WriteLine($"You guessed the right number. It was {random_number}!"); //tell the user they got it right
                loop_it = false; //turn off the loop 
                
            }
            else if (guessed_number < random_number)
            {
                Console.WriteLine("Correct number is higher.");
            }
            else if (guessed_number > random_number)
            {
                Console.WriteLine("Correct answer is lower.");
            }
        }
    }
}


//notes --

//Despite the code being the exact as the example, 
//I made sure to type it out myself to better retain what I'm learning.

//I do think I need to ask AI questions about how certain aspects of the code works together.
//The part about taking info from the user and then storing it doesn't quite click for me in C# as it does in python.

//I originally tried to make the while loop condition be dependant upon 
//if the two numbers were different or not. That was great until I wanted
// to keep putting different guesses in, in which it wouldn't work due to 
//an undefined variable being a parameter for the while loop. I settled with a boolean variable instead. Much easier!

//I feel like the stretch goals would've made this assignment easier to 
//start by simply throwing in another variable to manage the while loop 
//rather than fooling with the two numbers.

//I could add another while loop to set up the function to opt in or out of the project but that's a bit gross.
