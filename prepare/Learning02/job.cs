using System;

public class Job
{
    public string JobTitle;
    public string CompanyName;
    public int StartYr; 
    public int EndYr;

    public void Display()
    {
        Console.WriteLine($"{JobTitle} {CompanyName} {StartYr} {EndYr}");
    }
}