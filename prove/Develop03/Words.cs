using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

class Words
{
    public List<string> splitVerses = new List<string>();

    public void SplitVerses(string verses)
    {
        splitVerses.Clear();
        foreach (string word in verses.Split(" "))
        {
            splitVerses.Add(word);
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        
        int hideRange = random.Next(1, 5);

        if (hideRange > splitVerses.Count)
        {
            Console.WriteLine($"{splitVerses}");
        }
        else
        {
            for (int i = 0; i < hideRange; i++)
            {
                int randomWordIndex = random.Next(0, splitVerses.Count);
                string wordToHide = splitVerses[randomWordIndex];
                string hiddenWord = new string('_', wordToHide.Length);
                splitVerses[randomWordIndex] = hiddenWord;
            }
        }
    }

    public bool IsAllHIdden()
    {
        return splitVerses.All(word => word.Contains("_"));
    }
}