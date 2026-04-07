public class Activity
{
    //Attributes
    private string _name;
    private string _description;
    private int _duration;
    //Constructors
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    //Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        Console.Clear();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity!");
    }
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            string numbers = i.ToString();
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write("\b \b");
            }
        }
    }
    public int GetDuration()
    {
       return _duration;
    }
}