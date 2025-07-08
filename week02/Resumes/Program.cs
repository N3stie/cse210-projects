using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

         // Create the first job
        Job job1 = new Job();
        job1.jobTitle = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        // Create the second job
        Job job2 = new Job();
        job2.jobTitle = "Manager";
        job2.company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2023;

        // Create the resume and assign the name
        Resume myResume = new Resume();
        myResume.name = "Allison Rose";

        // Add the jobs to the resume
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        // Display the resume
        myResume.display();
    }
}