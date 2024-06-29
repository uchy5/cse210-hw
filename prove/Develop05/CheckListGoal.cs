namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        public int TargetCount { get; }
        public int BonusPoints { get; }
        public int CompletedCount { get; private set; }

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
        {
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            CompletedCount = 0;
        }

        public override int Complete()
        {
            CompletedCount++;
            if (CompletedCount >= TargetCount)
            {
                return Points + BonusPoints;
            }
            return Points;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Completed: {CompletedCount}/{TargetCount}";
        }
    }
}
