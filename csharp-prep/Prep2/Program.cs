using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is the precentage of your grade?");
        string user_answer = Console.ReadLine();
        int percent = int.Parse(user_answer);
        string Grade_letter = "";

        if (percent >= 95)
            {
                Grade_letter = "A+";
            } 
        else if (percent >= 90)
            {
                Grade_letter = "A-";
            }
        else if (percent >= 85)
            {
                Grade_letter = "B+";
            }
        else if (percent >= 80)
            {
                Grade_letter = "B-";
            }
        else if (percent >= 75)
            {
                Grade_letter ="C+";
            }
        else if (percent >= 70)
            {
                Grade_letter = "C-";
            }
        else if (percent >= 65)
            {
                Grade_letter = "D+"; 
            }
        else if (percent >= 60)
            {
                Grade_letter = "D";
            }
        else
            {
                Grade_letter = "F";
            }
        
        Console.WriteLine($"Your grade is :{Grade_letter}");

        if (percent >= 70)
            {
                Console.WriteLine("You passed the class!!");
            }
         else
            {
                Console.WriteLine("You have failed, better luck next time :)");
            }
    }
}