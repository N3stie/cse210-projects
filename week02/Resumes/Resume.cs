using System;
using System.Collections.Generic;


public class Resume
{
    public string name;
    public List<Job> jobs = new List<Job>();

    public void display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in jobs)
        {
            job.display();
        }
    }
}