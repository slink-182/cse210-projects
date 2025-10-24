class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;

    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}: {_response}");
    }
    public string ToFileString()
    {
        return $"{_date} | {_prompt} | {_response}";
    }
}