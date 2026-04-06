public class Assignment
{
    //Atributes
    private string _studentName;
    private string _topic;
    //Constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    //Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}