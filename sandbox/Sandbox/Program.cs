using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        // Person person = new Person();
        // person.SetName("Mr.", "Mason", "Cockrum");
        // person.DisplayFullName();

        // Print.HelloWorld();

        
        //create an account to run methods for
        Account _myAccount = new Account("002", 25.00, "Alice");

        bool _running = true;
        while (_running)
        {
            //write to the terminal to set up the context for what the user is supposed to input
            Console.WriteLine("1. Desposit\n2. Withdraw\n3. Transfer\n4. View Account\n5. Exit\n-+-");
            Console.Write("Input answer: ");
            //stores what the user inputs into var "_choice"
            string _choice = Console.ReadLine();

            //set up the if, and else if, statements<3
            if (_choice == "1")
            {
                Console.Write("Deposit Amount: ");
                string _input = Console.ReadLine();
                double _amount;

                if (double.TryParse(_input, out _amount))
                {
                    _myAccount.Deposit(_amount);
                }
                else
                {
                    Console.WriteLine("Invalid amount entered.");
                }

            }
            else if (_choice == "2")
            {

            }
            else if (_choice == "3")
            {

            }
            else if (_choice == "4")
            {
                _myAccount.ViewAccount();
            }
            else if (_choice == "5")
            {
                _running = false;//exit the program
                Console.WriteLine("Thank you, have a great day<3");
            }
        } 
    }
    
}



