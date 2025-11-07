public class BaseClass
{
    private string _fName;
    private string _lName;

    public BaseClass(string fname, string lname)
    {
        _fName = fname;
        _lName = lname;
    }

    public string GetFullName()
    {
        return _fName + " " + _lName;
    }
    
}