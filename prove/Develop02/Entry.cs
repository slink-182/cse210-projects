public class Entry
{
    private string _date;
    private string _prompt;
    private string _userInput;

    public Entry(string date, string prompt, string userInput)
    {
        _date = date;
        _prompt = prompt;
        _userInput = userInput;
    }

    //get the full entry with date, prompt, and user response
    public string GetEntry()
    {
        return $"{_date} // {_prompt}: {_userInput}";
    }


    //get the individual attributes because we can
    public string GetDate()
    {
        return $"{_date}";
    }
    public string GetPrompt()
    {
        return $"{_prompt}";
    }
    public string GetUserInput()
    {
        return $"{_userInput}";
    }
}