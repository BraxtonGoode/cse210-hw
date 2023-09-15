using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //random number generator//
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,20);

       
        

        int numGuess = 0;


        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            numGuess = int.Parse(guess);

            if (numGuess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (numGuess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (numGuess != randomNumber);

        

        

        

    }
}