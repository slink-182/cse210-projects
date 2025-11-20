using System.Runtime.CompilerServices;

public class Journal
{
    //attributes
    private List<string> _promptList;
    private List<string> _answerList;
    
    public Journal(List<string> prompt, List<string> answer)
    {
        _promptList = prompt;
        _answerList = answer;
    }

    public void DisplayJournal()
    {
        for (int i = 0; i < _promptList.Count; i++)
        {
            Console.WriteLine(_promptList[i]);
            Console.WriteLine(_answerList[i]);
            Console.WriteLine(); 
        }
        
        
    }

}