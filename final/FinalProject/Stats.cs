public class Stats
{
    private static readonly Random random = new Random();
    
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }
    public int AttackPower { get; private set; }

    public Stats(int maxHealth, int attackPower)
    {
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        AttackPower = attackPower;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth < 0)
            CurrentHealth = 0;
    }

    public void UpdateAttackPower(int attackPower)
    {
        AttackPower = attackPower;
    }

    public bool IsAlive() => CurrentHealth > 0;

    public int GenerateRandomDamage()
    {
        // Random damage between 5 and AttackPower
        return random.Next(5, AttackPower + 1);
    }
}
