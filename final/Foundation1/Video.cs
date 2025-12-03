using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    public void DisplayVideo(bool includeComment)
    {

        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nDuration: {_duration}");
        if (includeComment)
        {
            DisplayComments();
        }
    }
    public void DisplayComments()
    {
        for (int i =0; i < _comments.Count; i++)
        {
            _comments[i].Display();
        }
    }

}