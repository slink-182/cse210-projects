using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // List<int> numbers = new List<int>();//created a list containing ints
        // List<string> words = new List<string>();//created a list containing strings

        // //add items to the string list
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // Console.WriteLine($"there are {words.Count} items in the Words list.");//count the number of items in the list

        // //use foreach to see all items in the list
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        //prep 4
        bool cycle = true;//set condition for while loop
        List<int> number_list = new List<int>();//make the number list
        while (cycle == true)//use boolean to turn on or off while loop
        {
            Console.Write("input a number, and type 0 when finished: ");
            string str_user_number = Console.ReadLine();
            int user_number = int.Parse(str_user_number);
            number_list.Add(user_number);
            int sum = 0;
            if (user_number == 0)
            {
                int largest_number = 0;
                //print out each item in number_list<3
                foreach (int number in number_list)
                {
                    Console.Write($"{number}, ");//list the numbers horizontally separated by commas
                    sum += number;//add each number to the sum

                    if (number > largest_number)//check for larger number
                    {
                        largest_number = number;
                    }
                }
                int number_of_items = number_list.Count;//calc number of items in list
                double number_list_average = sum / number_of_items;//calc average

                Console.WriteLine();//break the line separating the list of numbers from listing  sum, average, and largest number
                Console.WriteLine($"the sum is: {sum}.");//print the sum
                Console.WriteLine($"the average is: {number_list_average}.");//print the average
                Console.WriteLine($"the largest number is: {largest_number}.");//print the largest number

                cycle = false;//turn off the original while loop


            }
        }
    }
}

//notes --

//I figured out during class today that read and write are what 
//differentiates between what the system stores versuses what it 
//prints to the terminal.

//Read tells the sys to record what was input, while write simply 
//prints information to the terminal.
//It's a little different than the input cmd in python where it 
//combines both the prompt and where you put your answer