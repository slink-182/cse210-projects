public class Simple : Goal
{
    //attributes
    bool _complete = false;

    public Simple(bool complete, string goalName, int goalValue, int pointTotal) : base(goalName, goalValue, pointTotal)
    {
        _complete = complete;
    }

    //methods
    public override void SetGoal()
    {
        // string _goalName = goalName;
        // return _goalName;
        
    }
    public override void UpdateGoal()
    {
        

    }



}