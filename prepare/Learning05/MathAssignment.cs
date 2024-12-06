public class MathAssignment : Assignment
{
    private string _section = "";
    private string _problems = ""; 

    public string GetSection()
    {
        return _section;
    }
    public void SetSection(string section)
    {
        _section = section;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";

    }
}