public class Entry
{
    //Attributes
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _userMood;


    //Constructor 
    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    //Methods
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"My Entry: {_entryText}");
        Console.WriteLine($"Mood of the day: {_userMood}");
    }
}