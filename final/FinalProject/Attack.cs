public class Attack
{
    public string Name { get; private set; }
    public int Damage { get; private set; }

    public Attack(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void Execute(Character attacker, Character target)
    {
        Console.WriteLine($"{attacker.Name} attacks {target.Name} with {Name}, dealing {Damage} damage.");
        target.Stats.TakeDamage(Damage);
    }
}
