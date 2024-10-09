public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] verseWords = [];
        verseWords = text.Split(" ");
        foreach (string word in verseWords)
        {
            Word aWord = new Word(word);
            _scripture.Add(new Word(word));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        Word randWord = _scripture[rand.Next(_scripture.Count)];
        for(int i = 0; i < numberToHide; i++)
        {
            randWord.Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}";
        foreach (Word word in _scripture)
        {
            Console.Write(word.GetDisplayText());
            Console.Write(" ");
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool Hidden = true;
        foreach (Word word in _scripture)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return Hidden;
    }
}