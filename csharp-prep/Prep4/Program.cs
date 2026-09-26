using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string user_Add = "";
        int user_Number = -1;
        int sum_Number = 0;
        int largest_Number = 0;
        List<int> added_Numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");

        while (user_Number != 0)
        {
            Console.Write("Enter a number: ");
            user_Add = Console.ReadLine();
            user_Number = int.Parse(user_Add);
            added_Numbers.Add(user_Number);
        }
        added_Numbers.RemoveAt(added_Numbers.Count -1);

        foreach (int number in added_Numbers)
        {
            sum_Number = sum_Number + number;
        }
        Console.WriteLine($"The sum is: {sum_Number}");

        float average_Number = ((float)sum_Number) / added_Numbers.Count;
        Console.WriteLine($"The average is: {average_Number}");

        foreach (int number in added_Numbers)
        {
            if (number > largest_Number)
            {
                largest_Number = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest_Number}");
    }
}