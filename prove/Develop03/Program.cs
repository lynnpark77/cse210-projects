using System;

//Exceeding requirement : I made a library class to get the scriptures randomly from the library of scriptures.
Library scriptureLibrary = new Library();
scriptureLibrary.AddScripture(new Reference("Provebs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.");
scriptureLibrary.AddScripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
scriptureLibrary.AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me.");

Scripture randomScripture = scriptureLibrary.GetRandomScripture();
string referenceText = randomScripture.GetReference().GetDisplayText();

while (true)
{
    Console.Clear();
    Console.WriteLine(referenceText + " " + randomScripture.GetDisplayText());

    if(randomScripture.IsCompletelyHidden())
    {
        break;
    }

    Console.WriteLine("\nPress Enter to continue or type 'quit' to finish: ");
    string userInput = Console.ReadLine();

    if (userInput == "quit")
    {
        break;
    }
    randomScripture.HideRandomWords(3);
    

}
