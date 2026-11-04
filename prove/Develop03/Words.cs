using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Words
{
    private List<string> _splitVerses = new List<string>();

    public void SplitVerses(string verses)
    {
        _splitVerses.Clear();
        foreach (string word in verses.Split(" "))
        {
            _splitVerses.Add(word);
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        
        int hideRange = random.Next(1, 5);

        if (hideRange > _splitVerses.Count)
        {
            Console.WriteLine($"{_splitVerses}");
        }
        else
        {
            for (int i = 0; i < hideRange; i++)
            {
                int randomWordIndex = random.Next(0, _splitVerses.Count);
                string wordToHide = _splitVerses[randomWordIndex];
                string hiddenWord = new string('_', wordToHide.Length);
                _splitVerses[randomWordIndex] = hiddenWord;
            }
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _splitVerses);
    }

    public bool IsAllHidden()
    {
        foreach (string word in _splitVerses)
        {
            if (!word.Contains("_"))
            {
                return false;
            }
        }
        return true;
    }
}