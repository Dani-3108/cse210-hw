using System;

class Program
{
    static void Main(string[] args)
    {
        //User Input
        Console.Write("What is your first name? ");
        String firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        String lastName = Console.ReadLine();

        //print statements
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}