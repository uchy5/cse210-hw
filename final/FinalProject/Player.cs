public class Player : Character
{
    public string Name { get; private set; }

    public Player(string name)
    {
        Name = name;
    }

    public override string GetTitle()
    {
        return $"Player: {Name}";
    }
}
