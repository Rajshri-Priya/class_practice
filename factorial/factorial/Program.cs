using System;
public class Factorial
{
    public static void Main(string[] args)
    {
        int i, fact = 1, num;

        Console.WriteLine("Enter any Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of " + num + " is: " + fact);
    }
}
