using System;

public class Player
{
    //i got bored and set defaults for the three attributes
    private int _health = 5;
    private string _name = "bob";
    private int _age = 22;
    

    public Player(){} //go with default parameters

    public Player(string name) //single parameter constructor
    {
        _name = name;
    }

    public Player(string name, int age) //take two parameters
    {
        _name = name;
        _age = age;
    }

    public Player(int health, string name, int age) //take three parameters
    {
        _health = health;
        _name = name;
        _age = age;

    }

    public void DisplayStats()
    {
        Console.WriteLine($"| NAME: {_name}\n| AGE: {_age}\n| HEALTH: {_health}");
    }

    public void TakeDamage()
    {
        int _damage = 5;
        _health = _health - _damage;

        Console.WriteLine($"You took {_damage} damage!");
        Thread.Sleep(2000);

        if (_health == 0)
        {
            Console.WriteLine("You died!");
        }
    }

    public void Heal()
    {
        if (_health > 100)
        {
            _health = 100;
        }

        Console.WriteLine($"your health is now {_health}.");
    }

    public void Jump()
    {
        
    }
    public void Walk()
    {
        
    }
    // create methods to send pieces of data to another file
    public int GetHealth()
    {
        return _health;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetAge()
    {
        return _age;
    }
    
}