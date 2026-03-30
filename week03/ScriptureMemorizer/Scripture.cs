public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for(int i=0; i < count; i++)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                
                _words[index].Hide();
            }
        }

    }


    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach(Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }

    public bool AllHidden()
    {
        
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
       
        }
       return true;  
    }
    

}

