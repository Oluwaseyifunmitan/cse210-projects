using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "GMS";
        job1._startYear = 2024;
        job1._endYear = 2026;
        job1.DisplayJobDetails();


         
        Job job2 = new Job();
        job2._jobTitle = "software Engineer";
        job2._company = "BYU";
        job2._startYear = 2026;
        job2._endYear = 2036;
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Oluwaseyi Makinde";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

       
    }
}