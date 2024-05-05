using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(UserNumber);
        
        DisplayResult(UserName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("wlecome to the program.");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter you name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the sauare of your number is {square}");
    }

}