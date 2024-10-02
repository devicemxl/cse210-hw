using System;
/*
Design the Classes
========================================================================================
You program should contain two classes one for a Job and one for the Resume itself, 
as follows:

Class: Job

Responsibilities:
Keeps track of the company, job title, start year, and end year.
Behaviors:
Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
Class: Resume

Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.
Based on these descriptions, you could create class diagrams like the following:
*/

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
        // testing #2
        // Software Engineer (Microsoft) 2019-2022
        // Manager (Apple) 2022-2023
        job1.Display();
        job2.Display();
    }
}