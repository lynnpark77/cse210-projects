using System;
using System.Globalization;

class ProgramteN
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            return name;

        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number^2;
            return square;
        }
        static void DisplayResult(string name,int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}