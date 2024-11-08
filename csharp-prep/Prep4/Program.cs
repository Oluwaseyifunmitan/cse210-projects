using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 

        int numbersEntered = -1;
        List<int> numbers = new List<int>();

        while (numbersEntered != 0)
        {
            Console.Write("Enter Number: ");
            numbersEntered = int.Parse(Console.ReadLine());

            if(numbersEntered != 0)
            {
                numbers.Add(numbersEntered);
            }
        }

        // Calculate the sum of numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        if (numbers.Count > 0)
        {
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("No numbers were entered to calculate an average.");
        }

        // Find the largest number
        if (numbers.Count > 0)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered to find the maximum.");
        }
    }
}
