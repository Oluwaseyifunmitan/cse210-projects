using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
       

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guessedNumber = -1;
       

        while (guessedNumber != number)
        {
        Console.Write("What is the magic number? ");

       string guess = Console.ReadLine();
       guessedNumber = int.Parse(guess);

       if (guessedNumber < number)
       {
        Console.WriteLine("Higher");
       }
       else if (guessedNumber > number)
       {
        Console.WriteLine("Lower");
        
       }
       else
       {
         Console.WriteLine("you guessed it!");
        

       }
        }

    }
}