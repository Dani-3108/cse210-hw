using System;
//Author: Daniel Osorio
//Exceeding Requirements: Asked the user also to put on his entry for a mood state and that is saved on the journal entry. Also added a menu introduction so the program would look more like an actual journal app.
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        //Introduction Mesage
        Console.WriteLine("Welcome to the Journal App");
        Console.WriteLine();
        Console.WriteLine("This app will help you to mantain your habits or reaching constantly your goal of writing on a Journal.");
        Console.WriteLine("And for that to be easier for you so you don't need to think what you should write, the app will provide prompts so you can focus on something specific and meaningfull.");
        Console.WriteLine("Remeber the powerfull quote by Christina Baldwin:");
        Console.WriteLine("'Journal writing is a voyage to the interior.'");
        Console.WriteLine();
        Console.WriteLine("Enjoy this time of writing!!");
        Console.WriteLine();
        //While loop
        int userNumber = 0;
        while (userNumber != 5)
        {
            Console.WriteLine("\nSelect one of the following options: ");
            Console.WriteLine("1: Write a new entry");
            Console.WriteLine("2: Display the journal");
            Console.WriteLine("3: Save the journal to a file");
            Console.WriteLine("4: Load the journal from a file");
            Console.WriteLine("5: Quit");
            Console.Write("What Option do you choose? ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            Console.WriteLine();
            if (userNumber == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt of the day: {prompt}.");
                Console.WriteLine("Your Entry: ");
                string userEntry = Console.ReadLine();
                Console.WriteLine("What is your mood of today? ");
                string moodState = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = userEntry;
                newEntry._userMood = moodState;
                myJournal.AddEntry(newEntry);
        
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("This are all the entries you have wrote until now;");
                myJournal.DisplayAll();
            }
            else if (userNumber == 3)
            {
                Console.Write("What is the file name where you want to store your entry? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Entry successfully saved!");
            }
            else if (userNumber == 4)
            {
                Console.Write("What is the file name from where you want to load your entries? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Entries loaded successfully!");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("You took time to listen to yourself today—that matters. See you when you return.");
            }
            else
            {
                Console.WriteLine("Invalid option, please select a number between 1 and 5.");
            }
        }
    }
}