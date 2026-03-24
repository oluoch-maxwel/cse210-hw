public class Reference
{
    //Attributes
    private string _word;
    private int _chapter;
    private int _verse;

    //Constructor
    public Reference(string word, int chapter, int verse)
    {
        _word = word;
        _chapter = chapter;
        _verse = verse;
    }

    //Methods
    public string GetDisplayText()
    {
        return $"{_word} {_chapter} {_verse}";
    }

}
