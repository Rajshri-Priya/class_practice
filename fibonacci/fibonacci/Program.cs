using System;
public class Logical_Programs
{
    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 1, n3, i, number;//variable declaration

        Console.WriteLine("Enter the number of elements: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " "); //printing 0 and 1 //0 1 1 ......   
        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        {
            n3 = n1 + n2;
            Console.Write(n3 + " "); //4=0113//5=0113
            n1 = n2;
            n2 = n3;
        }
    }
}