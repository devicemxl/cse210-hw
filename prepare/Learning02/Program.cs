using System;

class Program
{
    static void Main(string[] args)
    {
        // Job #1
        Job job1        = new Job();
        job1._jobTitle  = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear   = 2022;
        // Job #2
        Job job2        = new Job();
        job2._jobTitle  = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear   = 2023;
        /*
        // testing #2
        // Software Engineer (Microsoft) 2019-2022
        // Manager (Apple) 2022-2023
        // job1.Display();
        // job2.Display();
        */
        /*
        // testing #3
        */
        Resume resumeN  = new Resume();
        resumeN.Display();
    }
}