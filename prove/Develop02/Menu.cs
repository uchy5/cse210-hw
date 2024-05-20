using System;
using System.Collections.Generic;
using System.IO;

public class Menu
{
    public Journal journal = new Journal();

    public void Show()
    {
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("0 - Quit");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Display the journal");
            Console.WriteLine("3 - Save the journal to a file");
            Console.WriteLine("4 - Load the journal from a file");
            Console.WriteLine("5 - Display entries from the file");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Quitting the program.");
                        break;
                    case 1:
                        string prompt = Prompt.PickPrompt();
                        journal.AddEntry(prompt);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        journal.SaveToFile();
                        break;
                    case 4:
                        journal.LoadFromFile();
                        break;
                    case 5:
                        journal.DisplayEntriesFromFile();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 0);
    }
}

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public const string Filename = "journal.csv";

    public void AddEntry(string prompt)
    {
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        entries.Add(new Entry(prompt, response, date));
        Console.WriteLine("Entry added successfully.\n");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(Filename))
        {
            writer.WriteLine("Date,Prompt,Response");
            foreach (var entry in entries)
            {
                string safePrompt = entry.Prompt.Replace("\"", "\"\"");
                string safeResponse = entry.Response.Replace("\"", "\"\"");
                writer.WriteLine($"\"{entry.Date}\",\"{safePrompt}\",\"{safeResponse}\"");
            }
        }
        Console.WriteLine("Journal saved successfully.\n");
    }

    public void LoadFromFile()
    {
        if (!File.Exists(Filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();
        using (StreamReader reader = new StreamReader(Filename))
        {
            string line;
            bool isFirstLine = true;
            while ((line = reader.ReadLine()) != null)
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue;
                }
                var parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    var date = parts[0].Trim('"');
                    var prompt = parts[1].Trim('"').Replace("\"\"", "\"");
                    var response = parts[2].Trim('"').Replace("\"\"", "\"");
                    entries.Add(new Entry(prompt, response, date));
                }
            }
        }
        Console.WriteLine("Journal loaded successfully.\n");
    }

    public void DisplayEntriesFromFile()
    {
        if (!File.Exists(Filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        using (StreamReader reader = new StreamReader(Filename))
        {
            string line;
            bool isFirstLine = true;
            while ((line = reader.ReadLine()) != null)
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue;
                }
                var parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    var date = parts[0].Trim('"');
                    var prompt = parts[1].Trim('"').Replace("\"\"", "\"");
                    var response = parts[2].Trim('"').Replace("\"\"", "\"");
                    var entry = new Entry(prompt, response, date);
                    Console.WriteLine(entry);
                }
            }
        }
    }
}

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}