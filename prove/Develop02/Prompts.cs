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
        "Write a poem inspired by the beauty of the natural world and its connection to human emotions.",
        "Create a story about a character who unexpectedly inherits a vast fortune or a powerful position they never wanted. How do they handle their new responsibilities, and what conflicts arise from their reluctance?",
        "Write about a painting that has been passed down through generations and is rumored to be haunted. What is the story behind the painting, and what happens when someone tries to uncover the truth?",
        "Describe a universe that is parallel to ours but with one major difference that significantly alters life as we know it. Explore how this difference impacts daily life, culture, and society.",
        " Tell the story of a person who receives a letter from someone they thought was lost forever. What does the letter say, and how does it change their life?",
        "Imagine a world where superpowers are common, but they often malfunction or come with unintended side effects. Write about a character whose powers have gone horribly wrong and how they cope with their situation.",
        "Write about a village that has been forgotten by the modern world. What unique customs and traditions have developed in isolation, and how do the villagers react when they are rediscovered?",
        "Create a narrative set on a recently discovered exoplanet. Describe its environment, the forms of life that inhabit it, and the challenges humans face in exploring or colonizing it."
    };

    public static string PickPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
