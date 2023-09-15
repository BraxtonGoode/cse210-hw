using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //creating a list//
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int newNumber = 1;
        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            string numList = Console.ReadLine();
            newNumber = int.Parse(numList);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            
        }

        int sumOfList = 0;

        foreach (int number in numbers)
        {
            sumOfList = sumOfList + number;
        }
        
        float average = ((int) sumOfList ) / numbers.Count; 
        int largestNum = 0;

        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }

        }
        //Console.WriteLine(numbers.Count);
        Console.WriteLine($"The Sum is: {sumOfList}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The longest Number is: {largestNum}");
        
    }
}