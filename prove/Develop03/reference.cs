using System;

public class Reference
{
    public string ScriptureReference { get; private set; }

    public Reference(string reference)
    {
        ScriptureReference = reference;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"Scripture Reference: {ScriptureReference}");
    }
}
