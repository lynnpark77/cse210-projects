using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Emily Blunt");
        assignment1.SetTopic("Week01 Assignment");
        
        MathAssignment math1 = new MathAssignment();
        math1.SetStudentName("Roberto Rodriguez");
        math1.SetTopic("Fractions");
        math1.SetSection("7.3");
        math1.SetProblems("8-19");

        WritingAssignment writing1 = new WritingAssignment();
        writing1.SetStudentName("Mary Waters");
        writing1.SetTopic("European History");
        writing1.SetTitle("The Causes of World War II");
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());

    }
}