using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write("What is the magic number?  ");
        //string magicNumber = Console.ReadLine();
        //int x = int.Parse(magicNumber);
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1,101);

        int y = -1;

        while ( x != y)
        {
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
}