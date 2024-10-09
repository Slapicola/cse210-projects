public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text) 
    {
        _isHidden = false;
        _text = text;
    }


    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        _isHidden = false;
        if (_isHidden == true)
        {
            return _isHidden;
        }
        else
        {
            return _isHidden;
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_text}";
        string blank = "_";
        if (_isHidden == false)
        {
            return displayText;
        }
        else
        {
            return blank;
        }
    }
}