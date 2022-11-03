using System;
public class Logical_Programs
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number to reverse");
        int Num = Convert.ToInt32(Console.ReadLine());//for converting into integer
        int Reverse = 0;
        while (Num > 0)
        {
            int remainder = Num % 10;//r= 151 % 10:1   //15%10:5 //1%10:1
            Reverse = (Reverse * 10) + remainder;//0*10+1=1 // 1*10+5:15 //15*10+1=151
            Num = Num / 10;//n=15 //1 //0

        }
        Console.WriteLine("Reverse No. is ", Reverse);
    }
}