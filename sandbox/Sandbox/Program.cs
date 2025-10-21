using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.SetName("Mr.", "Mason", "Cockrum");
        person.DisplayFullName();

        Print.HelloWorld();
    }
    
}

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public void SetName(string title, string firstName, string lastName)
    {
        _title = title;
        _firstName = firstName;
        _lastName = lastName;
    }

    public void DisplayFullName()
    {
        Console.WriteLine($"full name: {_title} {_firstName} {_lastName}");
    }


}

