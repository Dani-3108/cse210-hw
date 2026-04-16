using System;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("03 Nov 2025", 30, 4.8);
        Cycling cycling1 = new Cycling("04 Nov 2025", 25, 80.5);
        Swimming swimming1 = new Swimming("05 Nov 2025", 60, 50);

        List<Activity> activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}