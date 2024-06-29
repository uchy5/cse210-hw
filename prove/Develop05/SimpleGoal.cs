namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override int Complete()
        {
            // Simple goals are instantly completed
            return Points;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
