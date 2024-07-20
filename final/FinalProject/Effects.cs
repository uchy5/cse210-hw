public abstract class Effect
{
    public string Name { get; private set; }
    public int Duration { get; private set; }

    public Effect(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public abstract void Apply(Character target);
    public abstract void Remove(Character target);
}
