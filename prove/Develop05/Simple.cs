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
        Console.WriteLine("is your goal completed?\n> ");
        string _answer = Console.ReadLine();


    }

}

/* 
the current proble. I'm having is with the SetGoal() method. 
If i'm currently plugging in attributes into the parameters of an object, what is the point of the constructor or the methods in this class?
All the logic could be in program.cs which would break encapsulation.

The question still stands -- how am I supposed to create an object that expects parameters that are not declared until we hit a method that defines them?
*/