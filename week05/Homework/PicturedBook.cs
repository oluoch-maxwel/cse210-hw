public class PicturedBook : Book
{
    private string _illustrator;
    public PicturedBook(string title, string author, string illustrator)
    : base(title, author)
    {
        _illustrator = illustrator;
    }

    public string GetIllustratorInfo() 
    {
        return $"{GetTitle()} by {GetAuthor()} illustrated by {_illustrator}";
    }
}