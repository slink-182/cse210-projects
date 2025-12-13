public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int min)
    {
        _date = date;
        _minutes = min;
    }
    
    //methods
    public abstract string GetActivityName();//define a method in the superclass that is overridden in the subclasses to protray the activity name
    public abstract string GetSummary(); //similarly, override this declared method with the appropriate data for each subclass summary
    public abstract double GetDistance();//override to get distance for each subclass activity type
    public abstract double GetSpeed();//also override this method to find speed for each activity
    public abstract double GetPace();//and finaly add pace to override in the subclasses 

    //getters
    public string GetDate()//date
    {
        return _date;
    }
    public int GetMinutes()//minutes
    {
        return _minutes;
    }
}