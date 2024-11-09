using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?  ");
        string number = Console.ReadLine();
        int x = int.Parse(number);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int y = int.Parse(guess);

        if (x > y)
        {
            Console.WriteLine("Higher");
        }
        else if (x < y)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}