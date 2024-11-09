using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?  ");
        string number = Console.ReadLine();
        int x = int.Parse(number);

        string response = "You guessed it!";
        while (response != "You guessed it!")
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int y = int.Parse(guess);

            if (x > y)
            {
                response = "Higher";
            }
            else if (x < y)
            {
                response = "Lower";
            }
            else
            {
                response = "You guessed it!";
            }
        
            Console.WriteLine($"{response}");
        }
    } 
}