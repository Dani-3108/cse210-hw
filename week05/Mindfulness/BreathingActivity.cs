public class BreathingActivity : Activity
{
    //Attributes : None

    //Constructors
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0)
    {

    }
    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready..");
        ShowSpinner(7);
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}