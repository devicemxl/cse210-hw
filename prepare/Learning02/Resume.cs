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

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}
