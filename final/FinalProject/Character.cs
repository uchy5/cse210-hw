public abstract class Character
{
    private static readonly Random random = new Random();
    private static readonly List<string> allClasses = new List<string> { "Rogue", "Mage", "Warrior", "Ranger", "Healer" };

    public string Name { get; protected set; }
    public string CharacterClass { get; private set; }
    public Stats Stats { get; private set; }

    public Character(string name)
    {
        Name = name;
        CharacterClass = AssignRandomClass();
        Stats = new Stats(GenerateRandomHealth(), GenerateRandomAttackPower());
    }

    private static string AssignRandomClass()
    {
        int index = random.Next(allClasses.Count);
        return allClasses[index];
    }

    private static int GenerateRandomHealth()
    {
        return random.Next(50, 1001); // Random health between 50 and 1000
    }

    private static int GenerateRandomAttackPower()
    {
        return random.Next(10, 51); // Random attack power between 10 and 50
    }

    public abstract void Attack(Character target);
    public abstract string GetTitle();
    public abstract void DisplayInfo();
}
