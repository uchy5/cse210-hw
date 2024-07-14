using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter player's name: ");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);
            Enemy enemy = new Enemy();
            NPC npc = new NPC();

            DisplayCharacterInfo(player);
            DisplayCharacterInfo(enemy);
            DisplayCharacterInfo(npc);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void DisplayCharacterInfo(Character character)
    {
        Console.WriteLine(character.GetTitle());
        Console.WriteLine("Assigned class: " + character.GetClass());
        Console.WriteLine();
    }
}
