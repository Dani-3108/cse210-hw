using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment class1 = new Assignment("Samuel Bennet", "Multipication");
        Console.WriteLine(class1.GetSummary());

        MathAssignment test2 = new MathAssignment("Samuel Bennet", "Multipication", "Section 7.3", "Problems 8-19");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeWorkList());

        WritingAssignment test3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}