using System;
using System.Collections.Generic;

class Reference
{
    private List<string> _references = new List<string>();
    public void NewScriptureReference()
    {
        Console.WriteLine("What is the reference for the scripture you would like to add? (ie. 2 Nephi 5:17, Matthew 7:3-5)");
        Console.Write("~ ");
        string addedReference = Console.ReadLine();
        Scripture newScripture = new Scripture();
        newScripture.NewScriptureVerses(addedReference);
    }

    private void RetrieveReferences()
    {
        _references.Clear();
        string filename = "Scriptures.csv";

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');

            _references.Add(parts[0]);
            
        }
        int index = 1;
        foreach (string reference in _references)
        {
            Console.WriteLine($"{index}. {reference}");
            index++;
        }
    }

    private int SelectReference(int maxCount)
    {
        Console.WriteLine("What scripture would you like to Memorize today?");
        Console.Write("~ ");
        string referenceChoice = Console.ReadLine();

        if (int.TryParse(referenceChoice, out int selected) && selected > 0 && selected <= maxCount)
        {
           return selected; 
        }
        return -1;

    }

    public int DisplayReferences()
    {
        RetrieveReferences();

        int totalReferences = _references.Count;
        int choice = SelectReference(totalReferences);
        Console.WriteLine($"DEBUG: totalReferences is {totalReferences}");
        if (choice != -1)
        {
            Console.Clear();
            Console.WriteLine($"Please enjoy memorizing {_references[choice - 1]}.");
        }
        return choice;
    }
}