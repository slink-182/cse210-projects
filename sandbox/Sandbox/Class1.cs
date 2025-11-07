using System;
public class Class1 : BaseClass
{
    // input attributes
    private int _age;
    private int _health;

    public Class1(int age, int health, string fname, string lname) : base(fname, lname)
    {
        _age = age;
        _health = health;

    }
    public void Display()
    {
        string _fullName = GetFullName();
        Console.WriteLine($"age: {_age}");
        Console.WriteLine($"health: {_health}");
        Console.WriteLine($"full name: {_fullName}");
  
    }
}