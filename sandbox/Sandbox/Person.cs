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