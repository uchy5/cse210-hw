public class Item
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Use(Character target)
    {
        Console.WriteLine($"{target.Name} uses {Name}");
    }
}
