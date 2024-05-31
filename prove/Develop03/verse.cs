using System;
using System.Collections.Generic;
using System.Linq;

public class Verse
{
    public string Text { get; set; }
    private List<string> Words { get; }
    private HashSet<int> HiddenIndices { get; }

    public Verse(string text)
    {
        Text = text;
        Words = text.Split(' ').ToList();
        HiddenIndices = new HashSet<int>();
    }

    public void Display()
    {
        for (int i = 0; i < Words.Count; i++)
        {
            if (HiddenIndices.Contains(i))
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(Words[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public bool HideRandomWords(int count = 3)
    {
        var visibleIndices = Enumerable.Range(0, Words.Count).Where(i => !HiddenIndices.Contains(i)).ToList();
        if (!visibleIndices.Any())
        {
            return false;
        }

        var random = new Random();
        for (int i = 0; i < count && visibleIndices.Any(); i++)
        {
            int idx = visibleIndices[random.Next(visibleIndices.Count)];
            HiddenIndices.Add(idx);
            visibleIndices.Remove(idx);
        }
        return true;
    }
}
