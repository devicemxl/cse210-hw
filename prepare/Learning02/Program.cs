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
public class Job {
    // Responsibilities
    public string _companyName;
    public string _jobTitle;
    public int _yearStart;
    public int _yearEnding;
    // Behaviors
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_yearStart}-{_yearEnding}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    }
}