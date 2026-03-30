
public class Comment
{
    //Attributes
    public string _commenter;
    public string _commentText;

    public string Display()
    {
        return $"{_commenter}: {_commentText}";
    }
}
