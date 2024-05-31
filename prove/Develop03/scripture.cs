using System;

public class Scripture
{
    public Reference Reference { get; }
    public Verse Verse { get; }

    public Scripture(Reference reference, Verse verse)
    {
        Reference = reference;
        Verse = verse;
    }

    public void Display()
    {
        Console.Clear();
        Reference.DisplayReference();
        Verse.Display();
    }

    public bool HideRandomWords(int count = 3)
    {
        return Verse.HideRandomWords(count);
    }
}
