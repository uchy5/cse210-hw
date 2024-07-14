using System;
using System.Collections.Generic;

public abstract class Character
{
    private static readonly Random random = new Random();
    private static readonly List<string> allClasses = new List<string> { "Rogue", "Mage", "Warrior", "Ranger", "Healer" };
    private static readonly List<string> assignedClasses = new List<string>();
    private string characterClass;

    public Character()
    {
        characterClass = AssignUniqueClass();
    }

    private string AssignUniqueClass()
    {
        List<string> availableClasses = new List<string>(allClasses);
        foreach (string assignedClass in assignedClasses)
        {
            availableClasses.Remove(assignedClass);
        }

        if (availableClasses.Count == 0)
        {
            throw new InvalidOperationException("No available classes left to assign.");
        }

        string selectedClass = availableClasses[random.Next(availableClasses.Count)];
        assignedClasses.Add(selectedClass);
        return selectedClass;
    }

    public string GetClass()
    {
        return characterClass;
    }

    public abstract string GetTitle();
}
