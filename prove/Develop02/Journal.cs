using System.IO;
using System.Runtime.CompilerServices;
public class Journal
{
    public List<Entry> theJournal = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        
        theJournal.Add(newEntry);
    }
    
    public void DisplayAll()
    {

        foreach (Entry entry in theJournal)
        {
            entry.Display();
        }   
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file....");
        string fileName = "";
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in theJournal)
            {
                outputFile.WriteLine(e);
            }
        }

    }

    public void LoadFromFile(string file)
    {

    }

}