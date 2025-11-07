using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        //create users
        Class1 user1 = new Class1(25, 40, "jason", "jones");
        Class1 user2 = new Class1(23, 60, "james", "jones");
        Class1 user3 = new Class1(21, 80, "jarod", "jones");
        Class1 user4 = new Class1(19, 100, "jacob", "jones");
        Class1 user5 = new Class1(1, 1000, "BEEF", "jones?");

        //display user information
        user1.Display();
        user2.Display();
        user3.Display();
        user4.Display();
        user5.Display();



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



