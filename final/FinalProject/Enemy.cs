public class Enemy : Character
{
    public Enemy(string name) : base(name) { }

    public override void Attack(Character target)
    {
        int damage = Stats.GenerateRandomDamage();
        Console.WriteLine($"{Name} the {CharacterClass} attacks {target.Name} with {damage} damage.");
        target.Stats.TakeDamage(damage);
    }

    public override string GetTitle()
    {
        return $"Enemy: {Name}";
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{GetTitle()} - Class: {CharacterClass}, Health: {Stats.CurrentHealth}/{Stats.MaxHealth}, Attack Power: {Stats.AttackPower}");
    }
}
