using System;

namespace factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter the Number:");
            n = Convert.ToInt32(Console.ReadLine());//10

            Console.WriteLine("Factors:");

            for (i = 1; i <= n; i++)//1<=10
            {
                if (n % i == 0)//10%1=0; 10%2=5....
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}