using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

Journal theJournal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

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
        string _promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{_promptText}");
        Console.Write(">");
        string _entryText = Console.ReadLine();
        Entry newEntry = new Entry(_date, _promptText, _entryText);
        newEntry.Display();
    
    }
    else if(response == 2)
    {
        theJournal.DisplayAll();

    }

    // else if(response == 3)
    // {

    // }

} while (response != 5);
