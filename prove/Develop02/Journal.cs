using System.IO;
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

    }

    public void LoadFromFile(string file)
    {

    }

}