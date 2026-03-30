public class Video
{
    //Attributes
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentsList = new List<Comment>();
    //Constructor
    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    // Methods
    public void AddComment(Comment comment)
    {
        _commentsList.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _commentsList.Count;
    }
}