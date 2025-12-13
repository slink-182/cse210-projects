public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthmin)
    {
        _date = date;
        _lengthInMinutes = lengthmin;
    }

    //methods
    public abstract void GetSummary(); //return a string of the summary of all the information

    //getters
    public string GetDate()
    {
        return _date;
    }
    public int GetLengthInMin()
    {
        return _lengthInMinutes;
    }
}