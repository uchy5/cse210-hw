using System;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.CompanyName = "Microsoft";
        job1.StartYr = 2019;
        job1.EndYr = 2022;

        Job job2 = new Job();
        job2.JobTitle = "Manager";
        job2.CompanyName = "Apple";
        job2.StartYr = 2022;
        job2.EndYr = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}