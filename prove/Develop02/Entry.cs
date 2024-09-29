public class Entry //do I need to use the DateTime class here?
{
    public string _dateTime;
    public string _promptText;
    public string _text;


    public string Display()
    {
        string entry = ($"Date: {_dateTime} - Prompt: {_promptText}\n {_text}");
        Console.WriteLine();
        return entry;
    }

}