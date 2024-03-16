using System.IO;

public class Journal
{
    public List<Entry> _list = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _list.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _list)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))

            foreach (Entry entry in _list)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }

        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile(string file)
    {
        _list.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    if (parts.Length == 3)
                    {
                        Entry entryToAdd = new Entry();
                        entryToAdd._date = parts[0];
                        entryToAdd._promptText = parts[1];
                        entryToAdd._entryText = parts[2];
                        _list.Add(entryToAdd);
                    }
                }
            }

            Console.WriteLine("Journal loaded from file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }

    }

    public void SearchAndDisplay(string searchTerm)
    {
        List<Entry> filteredList = _list.FindAll(entry => entry._entryText.Contains(searchTerm));

        foreach (Entry entry in filteredList)
        {
            entry.Display();
        }

        Console.WriteLine("All results were displayed");
    }
}