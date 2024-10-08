using System;

class Program
{
    static void Main(string[] args)
    {
        // define the Jobs vector
        List<Job> theJobs = new List<Job>();
        //
        //
        // Job #1
        Job job1        = new Job();
        job1._jobTitle  = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear   = 2022;
        theJobs.Add(job1); // add this Job to theJobs
        // Job #2
        Job job2        = new Job();
        job2._jobTitle  = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear   = 2023;
        theJobs.Add(job2); // add this Job to theJobs
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
        // Create the resumeN object
        Resume resumeN  = new Resume();
        // populate the name
        resumeN._name = "Alison Rose";
        //
        // populate the resumeN
        foreach (Job job in theJobs) {
            resumeN._jobs.Add(job);
            }
        // define the jobs list
        resumeN.Display();
    }
}