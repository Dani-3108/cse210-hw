// Exceeding Requirements: I added an activity log that tracks how many times
// the user completed each activity during the session. When the user quits,
// the program displays a summary of their activity count for each type.

using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1.Start Breathing Activity");
            Console.WriteLine("  2.Start Reflecting Activity");
            Console.WriteLine("  3.Start Listing Activity");
            Console.WriteLine("  4.Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
            Console.Clear();
            if (userChoice == 1)
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
                breathingCount++;
            }
            else if (userChoice == 2)
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
                reflectingCount++;
            }
            else if (userChoice == 3)
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
                listingCount++;
            }
            else
            {
                Console.WriteLine($"You did {breathingCount} times the Breathing Activity!");
                Console.WriteLine($"You did {reflectingCount} times the Reflecting Activity!");
                Console.WriteLine($"You did {listingCount} times the Listing Activity!");
                Console.WriteLine("Thanks for your time of using the Mindfullness App!");
            }

        }
    }
}