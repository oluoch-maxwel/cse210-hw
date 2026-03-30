public class Word
{
    //Attributes
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); // same length as word
        }
        else
        {
            return _text;
        }
    }

}