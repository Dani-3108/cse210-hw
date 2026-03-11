public class PromptGenerator
{
    //Attributes
    public List<string> _prompts = new List<string>()
    {
        "What moment today do I want to remember a year from now, and why?",
        "What challenged me today, and how did I respond to it?",
        "When did I feel most like myself today?",
        "What did I learn about myself today, even in a small way?",
        "What am I grateful for right now that I might normally overlook?",
        "Where did I feel peace today, and what was happening in that moment?",
        "What thought or idea kept coming back to me throughout the day?",
        "How did I show kindness—to myself or to someone else—today?",
        "What drained my energy today, and what gave me energy?",
        "What is one prayer, hope, or intention I want to carry into tomorrow?"
    };
    //Methods
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, 10);
        return _prompts[index];
    }
}