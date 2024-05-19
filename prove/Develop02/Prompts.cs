using System;
using System.Collections.Generic;

public static class Prompt
{
    private static List<string> prompts = new List<string>
    {
        "Write a short story set in a world where time travel is possible but heavily regulated.",
        "Imagine a conversation between two unlikely allies negotiating a truce during a war.",
        "Describe a character's journey of self-discovery through a series of letters to their future self.",
        "Create a dystopian society where emotions are considered illegal and punishable by law.",
        "Write a poem inspired by the beauty of the natural world and its connection to human emotions."
    };

    public static string PickPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
