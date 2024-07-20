using System;
using System.Collections.Generic;

class Program
{
    private static readonly Random random = new Random();
    private static readonly List<Weapon> weapons = new List<Weapon>
    {
        new Weapon("Sword", "A sharp blade", 25),
        new Weapon("Axe", "A heavy axe", 30),
        new Weapon("Bow", "A long-range bow", 20),
        new Weapon("Dagger", "A small but deadly dagger", 15)
    };

    static void Main(string[] args)
    {
        Console.Write("Enter player's name: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName);
        Enemy enemy = new Enemy("Goblin");
        NPC npc = new NPC("Merchant");

        // Select a random weapon from the list
        Weapon selectedWeapon = weapons[random.Next(weapons.Count)];
        player.EquipWeapon(selectedWeapon);

        // Start the battle
        Battle battle = new Battle(player, enemy, npc);
        battle.Start();
    }
}
