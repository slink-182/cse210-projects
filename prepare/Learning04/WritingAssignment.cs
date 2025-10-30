// ANOTHER CLASS MUWAHAHAAHAHAHAHA
public class WritingAssignment : Assignment
{
    // create the attributes
    private string _title;

    // INHERITANCE YEEEEEE
    public WritingAssignment(string studentName, string topic, string title):base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetSummary()}";
    }
}