using System;

class Program
{
    static void Main(string[] args)
    {
        //creating the list 
        List<int> numbers = new List<int>();

        //input
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            String UserInput = Console.ReadLine();
            userNumber = int.Parse(UserInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //sum section
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");
        //average section 
        int length = numbers.Count;
        double average = ((double)sum) / length;
        Console.WriteLine($"The average is: {average}");
        //largest number section 
        int largest = numbers[0];
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        //smallest positive
        int smallestPositive = 999999999;
        foreach (int i in numbers)
        {
            if (i is > 0 && i < smallestPositive)
            {
                smallestPositive = i;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        //sorted list 
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}