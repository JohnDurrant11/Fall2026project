using System;

class Scripture
{
    private List<string> Scriptures = new List<string>();
    private string usedScripture;
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

    private string RetreaveScriptures(int choice)
    {
        Scriptures.Clear();
        string filename = "Scriptures.csv";

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');

            Scriptures.Add(parts[1]);
            
        }
        int usedReference = choice - 1;

        if (usedReference >= 0 && usedReference < Scriptures.Count)
        {
            usedScripture = (Scriptures[usedReference]);
        }
        else
        {
            Console.WriteLine("Scripture text not found.");
        }
        return usedScripture;
    }

    public void runScriptureGame(int choice)
    {
        Words HideVerses = new Words();

        HideVerses.SplitVerses(RetreaveScriptures(choice));
        string endSession = "";

        Console.WriteLine($"{usedScripture}");
        while (endSession != "quit")
        {
            Console.Clear();
            Console.WriteLine(string.Join(" ", HideVerses.splitVerses));

            Console.WriteLine("Hit enter to hide more words. Type 'quit' to end the game.");
            endSession = Console.ReadLine();
            HideVerses.HideWords();

            if (HideVerses.IsAllHIdden())
            {
                Console.Clear();
                Console.WriteLine("Congragulations on finishing this verse!");
                break;
            }
        }

    }
}