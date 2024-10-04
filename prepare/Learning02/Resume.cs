using System;
/*
Design the Class
========================================================================================
You program should contain two classes one for a Job and one for the Resume itself, 
as follows:

Class: Resume

Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.

Diagram:

Class: Resume
Attributes:
* _name : string
* _jobs : list

Behaviors:
* Display() : void
*/
public class Resume
{
    public string _name;

    // List of jobs
    public List<Job> _jobs = new List<Job>();
    // display
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        // for each Job in joblist
        foreach (Job job in _jobs)
        {
            // Display this Job
            job.Display();
        }
    }
}
