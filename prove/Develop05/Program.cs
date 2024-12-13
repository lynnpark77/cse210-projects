using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1.Start breathing activity");
            Console.WriteLine("  2.Start reflecting activity");
            Console.WriteLine("  3.Start listing activity");
            Console.WriteLine("  4.Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput);

            switch (userInput)
            {
                case "1" :
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;

                case "2" :
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                break;

                // case 3 :
                // Console.Clear();
                // ListingActivity listing = new ListingActivity();
                // listing.Run();
                // break;

                case "4" :
                Console.WriteLine("See you next time!!!");
                return;

                default :
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                Thread.Sleep(2000);
                break;
                
           
            }
        }


           
        


    }
}