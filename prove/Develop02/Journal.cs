using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry newEntry in _entries)
        {
            Console.WriteLine(newEntry.Display());
            Console.WriteLine("");
        }

    }
    public void SaveToFile(string file) //probably need to use the System to write files
    {
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //outputFile.WriteLine(entry);
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Display());
                Console.WriteLine();
            }
        }

    }
    public void LoadFromFile(string file) //use the System to read files
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Console.WriteLine(line);
        }

    }
}