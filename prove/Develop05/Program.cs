using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1.Start breathing activity");
            Console.WriteLine("  2.Start reflecting activity");
            Console.WriteLine("  3.Start listing activity");
            Console.WriteLine("  4.Quit");
            Console.WriteLine("Select a choice from the menu:");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput);

            if(response == 1)
            {
                
            }
        } while(response != 4);


           
        


    }
}