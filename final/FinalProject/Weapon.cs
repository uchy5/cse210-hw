public class Weapon : Item
{
    public int Damage { get; private set; }

    public Weapon(string name, string description, int damage) : base(name, description)
    {
        Damage = damage;
    }

    public override void Use(Character target)
    {
        Console.WriteLine($"{target.Name} equips {Name} - {Description} with {Damage} damage.");
    }
}
