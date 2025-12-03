public class Phone
{
    private double _battery = 100;
    private float _brightness = 53;
    private string _color = "orange";

    public Phone(double battery, float brightness, string color) //pass in all three: battery, brightness, and color
    {
        _battery = battery;
        _brightness = brightness;
        _color = color;
    }
    public Phone(double battery, float brightness) //pass in both battery and brightness
    {
        _battery = battery;
        _brightness = brightness;
    }
    public Phone(){} //create the object without any parameters


    public void Display()
    {
        Console.WriteLine($"Your phone is at {_battery} battery life, {_brightness} brightness, and is {_color}.");
    }
}