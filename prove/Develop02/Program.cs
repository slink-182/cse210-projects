using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {   
        //create the object
        Journal j = new Journal();


        //declare consts
        const int WRITE_NEW_ENTRY = 1;
        const int DISPLAY_JOURNAL = 2;
        const int SAVE_JOURNAL = 3;
        const int LOAD_JOURNAL = 4;
        const int QUIT = 5;

        bool RUNNING = true;//continuously run the menu until user input closes it
        while (RUNNING)
        {
            Console.WriteLine($"{WRITE_NEW_ENTRY}. write new entry");
            Console.WriteLine($"{DISPLAY_JOURNAL}. display journal");
            Console.WriteLine($"{SAVE_JOURNAL}. save journal");
            Console.WriteLine($"{LOAD_JOURNAL}. load journal");
            Console.WriteLine($"{QUIT}. quit");
            Console.Write("> ");

            //take the user input and convert it into an int from a string
            string _choiceSTR = Console.ReadLine();
            int _choice = int.Parse(_choiceSTR); 

            if (_choice == WRITE_NEW_ENTRY) //write a new entry
            {
                j.AddEntry();
            }
            else if (_choice == DISPLAY_JOURNAL) //display journal
            {
                j.DisplayTotalEntries();
            }
            else if (_choice == SAVE_JOURNAL) //save the journal
            {
                j.FileSave();
            }
            else if (_choice == LOAD_JOURNAL) //load journal
            {
                j.FileLoad();
            }
            else if (_choice == QUIT) //end the program
            {
                RUNNING = false;
            }


        }
    
    }


}

