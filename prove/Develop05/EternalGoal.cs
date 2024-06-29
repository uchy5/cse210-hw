namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override int Complete()
        {
            // Eternal goals can be completed multiple times
            return Points;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
