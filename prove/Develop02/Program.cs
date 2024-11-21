using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

Journal _theJournal = new Journal();
PromptGenerator _promptGenerator = new PromptGenerator();

Console.WriteLine("Welcome to the Journal Program!");

int response = 5;
do
{
    Console.WriteLine("Please select one of the following choices");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    string userInput = Console.ReadLine();
    response = int.Parse(userInput);

    if (response == 1)
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        string _promptText = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{_promptText}");
        Console.Write(">");
        string _entryText = Console.ReadLine();

        //Exceeding requirement -Save other information in the journal entry : I added a prompt for the user to write things they are thankful for. 
        
        Console.WriteLine("What are you thankful for today? ");
        string _gratitude = Console.ReadLine();
        Entry newEntry = new Entry(_date, _promptText, _entryText, _gratitude);
        _theJournal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully.");
    
    }
    else if(response == 2)
    {
        _theJournal.DisplayAll();

    }

    else if(response == 3)
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        _theJournal.LoadFromFile(fileName);
        _theJournal.DisplayAll();

    }

    else if(response == 4)
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        _theJournal.SaveToFile(fileName);
    }

} while (response != 5);
