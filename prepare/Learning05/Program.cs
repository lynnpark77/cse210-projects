using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Emily","Week01 Assignment");
        
        MathAssignment math1 = new MathAssignment();
        math1.SetStudentName("James");
        math1.SetTopic("Fractions");
        math1.SetSection("7.3");
        math1.SetProblems("8-19");
        
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());


    }
}