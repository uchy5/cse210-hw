using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
    
    Random randomGenerator = new Random();
    int MagicNumber = randomGenerator.Next(1, 101);

    int UserGuess = -1;

    while (UserGuess != MagicNumber)
    {
        Console.Write("what is your guess?");
        UserGuess = int.Parse(Console.ReadLine());
        if (MagicNumber > UserGuess)
        {
            Console.WriteLine("Higher");
        }

        else if (MagicNumber < UserGuess)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("you guessed the magic number");
        }
    }
    

    }

}