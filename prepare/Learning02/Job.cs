using System;
/*
Design the Class
========================================================================================

Class: Job

Responsibilities:
Keeps track of the company, job title, start year, and end year.
Behaviors:
Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
*/
public class Job {
    // Responsibilities
    public string _companyName;
    public string _jobTitle;
    public int _endYear;
    public int _startYear;
    // Behaviors
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}