using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResults(userName, SquaredNumber);






    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");

    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int FavNumber = int.Parse(favoriteNumber);
        return FavNumber;

    }
    static int SquareNumber(int number)
    {
        int Squared = number * number;
        return Squared;
    }
    static void DisplayResults(string name, int SquaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {SquaredNumber}.");

    }
}