using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Please select one of the following:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("~ ");

        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int menuChoice))
        {
           return menuChoice; 
        }
        return -1;
    }

    public void ChoiceNavigation(int choice)
    {
        if (choice == 1)
        {
            WriteNavigation();
        }
        else if (choice == 2)
        {
            DisplayNavigation();
        }
        else if (choice == 3)
        {
            LoadNavigation();
        }
        else if (choice == 4)
        {
            SaveNavigation();
        }
        else if (choice == 5)
        {
            QuitNavigation();
        }
        else
        {
            Console.WriteLine("That is not a valid input. Please enter a valid choice.");
        }
    }
        private List<Entry> _entryList = new List<Entry>();
        private PromptGeneration requestPrompt = new PromptGeneration();

    public void WriteNavigation()
    {
        Entry entryLoop = new Entry();
        entryLoop.Date = DateTime.Today;
        entryLoop.Request = requestPrompt.DisplayPrompt();
        entryLoop.Input = Console.ReadLine();
        _entryList.Add(entryLoop);
    }

    public void DisplayNavigation()
    {
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine($"Date: {entry.Date.ToShortDateString()} - Prompt: {entry.Request}");
            Console.WriteLine($"{entry.Input}");
            Console.WriteLine();
        }
    }

    public void LoadNavigation()
    {
        string filename = "Journal.csv";

        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: 'Journal.csv' could not be found. Try saving some entries first.");
            return;
        }

        _entryList.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(',');

            if (parts.Length >= 3)
            {
                Entry loadedEntry = new Entry();

                loadedEntry.Date = DateTime.Parse(parts[0]);
                loadedEntry.Request = parts[1].Trim('"');
                loadedEntry.Input = string.Join(",", parts, 2, parts.Length - 2).Trim('"');

                _entryList.Add(loadedEntry);
            }
        }
    }

    public void SaveNavigation()
    {
        string filename = "Journal.csv";

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
            {
                string Request = $"\"{entry.Request}\"";
                string Input = $"\"{entry.Input}\"";

                writer.WriteLine($"{entry.Date.ToShortDateString()},{Request},{Input}");
            }
        }

        Console.WriteLine("Journal entries saved.");
    }

    public void QuitNavigation()
    {
        Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
    }
}