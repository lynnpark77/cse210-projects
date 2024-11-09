using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);


        string letter = "";
        string sign ="";

        if (x>=90)
        {
            letter = "A";
        }
        else if (x>=80 && x<90)
        {
            letter = "B";
        }
        else if (x>=70 && x<80)
        {
            letter = "C";
        }
        else if (x>=60 && x<70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        int lastDigit = x % 10;
        if (lastDigit>= 7)
        {
            sign = "+";
        }
        else if (lastDigit <3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");
        
        if (x>=70)
        {
            Console.WriteLine("Congratualations! You passed the class");
        }
        else
        {
            Console.WriteLine("You didn't pass. Try again");
        }
    }
}