using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Fraction askNumbers = new Fraction();
        Console.Write("Enter the numerator: ");
        int topInput = int.Parse(Console.ReadLine());
        askNumbers.SetNumerator(topInput);
        Console.Write("Enter the denomerator: ");
        int bottomInput = int.Parse(Console.ReadLine());
        askNumbers.SetDenomerator(bottomInput);

        Console.WriteLine($"{askNumbers.GetFractionString()}");
        Console.WriteLine($"{askNumbers.GetDecimalValue()}");

        Random rnd = new Random();
        
        int loop = 0;
        while (loop != 20)
        {
            loop += 1;
            Fraction loopNumbers = new Fraction();
            loopNumbers.SetNumerator(rnd.Next(1, 101));
            loopNumbers.SetDenomerator(rnd.Next(1, 101));

            Console.WriteLine($"Fraction {loop}: string: {loopNumbers.GetFractionString()} Number: {loopNumbers.GetDecimalValue()}");
            
        }


    }
}