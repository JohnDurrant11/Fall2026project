using System;
using System.Collections.Generic;
using System.Dynamic;

public class PromptGeneration
{
    private static Random random = new Random();
    public List<String> Prompts = new List<string>();

    public PromptGeneration()
    {
        Prompts.Add("What was your favorite part of the day?");
        Prompts.Add("What made you smile?");
        Prompts.Add("Who could you have been nicer to?");
    }

    public string GetRandomString()
    {
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }

    public string DisplayPrompt()
    {
        string selectedPrompt = GetRandomString();
        Console.WriteLine(selectedPrompt);
        return selectedPrompt;
    }
}