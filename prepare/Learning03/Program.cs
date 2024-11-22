using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetTop()/f1.GetBottom());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetTop()/f2.GetBottom());

        Fraction f3 = new Fraction(3,4);
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetTop()/f3.GetBottom());
        
    }
}