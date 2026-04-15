using System;
// Exceeds Requirements: Added a leveling system to DisplayPlayerInfo() in GoalManager.cs
// Players progress through 4 levels based on their score:
// Level 1 Novice (0-499), Level 2 Apprentice (500-900), 
// Level 3 Hero (901-1999), Level 4 Legend (2000+)

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}