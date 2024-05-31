using System;

public class Program
{
    public static void Main()
    {
        Reference myReference = new Reference("John 3:16");
        Verse myVerse = new Verse("For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");
        Scripture scripture = new Scripture(myReference, myVerse);

        Console.WriteLine("Welcome to the Scripture Hiding Game!");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");

            string userInput = Console.ReadLine().Trim().ToLower();
            if (userInput == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (!scripture.HideRandomWords())
            {
                Console.WriteLine("All words have been hidden. Program ending.");
                break;
            }
        }
    }
}
