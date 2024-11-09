using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);

        if (x>=90)
        {
            Console.WriteLine("A");
        }
        else if (x>=80 && x<90)
        {
            Console.WriteLine("B");
        }
        else if (x>=70 && x<80)
        {
            Console.WriteLine("C");
        }
        else if (x>=60 && x<70)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
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