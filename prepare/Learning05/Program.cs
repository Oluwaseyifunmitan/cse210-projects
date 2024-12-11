using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
       Console.WriteLine(assignment.GetSummary());

       Math assignment2 = new Math("Section 7.3"," Problems 8-19");
       
    }
}