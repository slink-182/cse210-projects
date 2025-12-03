public abstract class Goal
{
    //attributes
    private string _goalName;
    private int _goalValue;
    private int _pointTotal;

    //constructor time<3
    public Goal(string name, int value, int total)
    {
        _goalName = name;
        _goalValue = value;
        _pointTotal = total;
    }

    //methods
    public abstract void SetGoal();//this would allow the user to set up the goals name and point value
    public abstract void UpdateGoal(); //this would allow the user to update the system on their progress on a goal

    public string GetGoalName() //return the goal name that the user input
    {
        return _goalName;
    }
    public int GetGoalValue() //return the goal value that the user input
    {
        return _goalValue;
    }

}