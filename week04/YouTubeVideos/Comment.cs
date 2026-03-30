public class Comment
{
    //Attributes
    public string _name;
    public string _commentText;
    //Constructor
    public Comment (string name, string text)
    {
        _name = name;
        _commentText = text;
    }
    //Methods
    public string GetText()
    {
        return $"{_name}: {_commentText}";
    }
}