using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        //create users
        // Class1 user1 = new Class1(25, 40, "jason", "jones");
        // Class1 user2 = new Class1(23, 60, "james", "jones");
        // Class1 user3 = new Class1(21, 80, "jarod", "jones");
        // Class1 user4 = new Class1(19, 100, "jacob", "jones");
        // Class1 user5 = new Class1(1, 1000, "BEEF", "jones?");

        // //display user information
        // user1.Display();
        // user2.Display();
        // user3.Display();
        // user4.Display();
        // user5.Display();

        // Phone phone0 = new Phone(); //this should return default values undefined by the player
        // Phone phone1 = new Phone(22.11, 69);
        // Phone phone2 = new Phone(15, 100, "blue");
        // phone0.Display();
        // phone1.Display();
        // phone2.Display();


        // Player p2 = new Player("jacob", 11);
        bool LOOPNAME = true;
        while (LOOPNAME)
        {
        Console.Write("What's your name?\n> ");
        string _userName = Console.ReadLine();
            if (_userName == "" || _userName == " " || _userName == "  ") //this is basically a blacklist of what we don't want to see
            {
                Console.WriteLine("user must input valid name.");
            }
            else
            {
                LOOPNAME = false;
                Player p = new Player(_userName);
                bool RUNNING = true;
                while (RUNNING)
                {
                    Console.Write("1. view stats\n2. take damage\n3. heal\n4. quit\n> ");
                    string userInput = Console.ReadLine();
                    
                    if (userInput == "1")
                    {
                        p.DisplayStats();
                    } else if (userInput == "2")
                    {
                        p.TakeDamage();
                    } else if (userInput == "3")
                    {
                        p.Heal();
                    } else if (userInput == "4")
                    {
                        Console.WriteLine("application closed<3");
                        RUNNING = false;
                    }else if (userInput == "5") //experimental / extra options not displayed to the user
                    {
                        //practice using methods to retrieve pieces of data
                        Console.WriteLine(p.GetName());
                        Console.WriteLine(p.GetAge());
                        Console.WriteLine(p.GetHealth());
                    }
                }
            }





            
        }

/*
    The funny thing is that we can use the object created to save values to a particular instance of the code. 
    We can run it again and do totally different things based on what each object.
    In this case, each if statement is grabbing the object and manipulating it with a different method that is defined within the player class.
    A new player could be added by declaring a new object. The problem is how we would do that considering the if statement is already tailored to one object, how do we swap that object?
*/ 
        // Person person = new Person();
        // person.SetName("Mr.", "Mason", "Cockrum");
        // person.DisplayFullName();

        // Print.HelloWorld();

        
        //create an account to run methods for
        // Account _myAccount = new Account("002", 25.00, "Alice");

        // bool _running = true;
        // while (_running)
        // {
        //     //write to the terminal to set up the context for what the user is supposed to input
        //     Console.WriteLine("1. Desposit\n2. Withdraw\n3. Transfer\n4. View Account\n5. Exit\n-+-");
        //     Console.Write("Input answer: ");
        //     //stores what the user inputs into var "_choice"
        //     string _choice = Console.ReadLine();

        //     //set up the if, and else if, statements<3
        //     if (_choice == "1")
        //     {
        //         Console.Write("Deposit Amount: ");
        //         string _input = Console.ReadLine();
        //         double _amount;

        //         if (double.TryParse(_input, out _amount))
        //         {
        //             _myAccount.Deposit(_amount);
        //         }
        //         else
        //         {
        //             Console.WriteLine("Invalid amount entered.");
        //         }

        //     }
        //     else if (_choice == "2")
        //     {

        //     }
        //     else if (_choice == "3")
        //     {

        //     }
        //     else if (_choice == "4")
        //     {
        //         _myAccount.ViewAccount();
        //     }
        //     else if (_choice == "5")
        //     {
        //         _running = false;//exit the program
        //         Console.WriteLine("Thank you, have a great day<3");
        //     }
        // } 
    }
    
}



