namespace EternalQuest
{
    abstract class Goal
    {
        public string Name { get; }
        public int Points { get; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public abstract int Complete();

        public override string ToString()
        {
            return $"{Name} - Points: {Points}";
        }
    }
}
