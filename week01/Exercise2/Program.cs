using System;

class Program
{
    static void Main(string[] args)
    {
        //User input: Grade percentage
        Console.Write("What is the grade percentage: ");
        String userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        //Letter variable
        string letter = "";

        //Letter A
        if (percentage >= 90)
        {
            letter = "A";
        }
        //Letter B
        else if (percentage >= 80)
        {
            letter = "B";
        }
        //Letter C
        else if (percentage >= 70)
        {
            letter = "C";
        }
        //Letter D
        else if (percentage >= 60)
        {
            letter = "D";
        }
        //Letter F
        else
        {
            letter = "F";
        }

        //sign section 
        int lastDigit = percentage % 10;
        String sign = "";
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        //expections
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        //grade letter print statement
        Console.WriteLine($"You have earned the grade {letter}{sign}.");
        //passed or failed the class if statements 
        if (percentage >= 70)
        {
            Console.WriteLine("Congrats! you passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the course. Try better next time.");
        }
    }
}