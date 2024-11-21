using System.IO;
using System.Runtime.CompilerServices;
public class Journal
{
    public List<Entry> _theJournal = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        
        _theJournal.Add(newEntry);
    }
    
    public void DisplayAll()
    {

        foreach (Entry entry in _theJournal)
        {
            entry.Display();
        }   
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file....");
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _theJournal)
            {
                outputFile.WriteLine(e.CreateString());
            }
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        List<Entry> journalEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string entryDate = parts[0].Trim();
            string entryPrompt = parts[1].Trim();
            string entryText = parts[2].Trim();
            string entryGratitude = parts[3].Trim();
            Entry newEntry = new Entry(entryDate,entryPrompt,entryText,entryGratitude);
            journalEntries.Add(newEntry);
        }
        _theJournal = journalEntries;
    }

}