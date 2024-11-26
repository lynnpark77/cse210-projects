using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3,5,6);
        Scripture scripture = new Scripture(reference,"Trust in the LORD with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.WriteLine(scripture);
        
    }
}