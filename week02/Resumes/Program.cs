using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine();
        
        Job job1 = new Job();
        job1._company = "Fox Cooling";
        job1._jobTitle = "Engineer";
        job1._startYear = 2017;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Ceinsa";
        job2._jobTitle = "Engineer";
        job2._startYear = 2004;
        job2._endYear = 2016;

        myResume resume = new myResume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Oswell Paintsil";

        resume.DisplayResume();

    }
}