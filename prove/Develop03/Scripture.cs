using System;

class Scripture
{
    private List<string> _scriptures = new List<string>();
    private string _usedScripture;
    public void NewScriptureVerses(string reference)
    {
        string filename = "Scriptures.csv";

        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            Console.WriteLine("Please place the verse(s) here.");
            Console.Write("~ ");
            string verses = Console.ReadLine();

            writer.WriteLine($"{reference}|{verses}");
        }
    }

    private string RetrieveScriptures(int choice)
    {
        _scriptures.Clear();
        string filename = "Scriptures.csv";

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');

            _scriptures.Add(parts[1]);
            
        }
        int usedReference = choice - 1;

        if (usedReference >= 0 && usedReference < _scriptures.Count)
        {
            _usedScripture = (_scriptures[usedReference]);
        }
        else
        {
            Console.WriteLine("Scripture text not found.");
        }
        return _usedScripture;
    }

    public void RunScriptureGame(int choice)
    {
        Words hideVerses = new Words();

        hideVerses.SplitVerses(RetrieveScriptures(choice));
        string endSession = "";

        Console.WriteLine($"{_usedScripture}");
        while (endSession != "quit")
        {
            Console.Clear();
            Console.WriteLine(hideVerses.GetDisplayText());

            Console.WriteLine("Hit enter to hide more words. Type 'quit' to end the game.");
            endSession = Console.ReadLine();
            hideVerses.HideWords();

            if (hideVerses.IsAllHidden())
            {
                Console.Clear();
                Console.WriteLine("Congratulations on finishing this verse!");
                break;
            }
        }

    }
}