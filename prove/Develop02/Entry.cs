public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = ""; 
    public string _gratitude = "";
    
    public Entry(string date, string promptText, string entryText, string gratitude)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _gratitude = gratitude;
    
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"{_gratitude}");
    }
    public string CreateString()
    {
        string text = $"Date: {_date} ~~ Prompt: {_promptText} ~~ {_entryText} ~~ {_gratitude}";
        return text;
    }

}