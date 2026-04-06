public class MathAssignment : Assignment
{
    //Attributes
    private string _textbookSection;
    private string _problems;
    //Constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //Methods
    public string GetHomeWorkList()
    {
        //section number and problmes
        return $"{_textbookSection} - {_problems}";
    }  
}