
//I made a library class to get the scriptures randomly from the library of scriptures.
public class Library
{
    private List<Scripture> _scriptures;

    public Library()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int randomIndex = random.Next(_scriptures.Count);
        return _scriptures[randomIndex];
    }
}