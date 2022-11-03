
using System;
public class Palindrome
{
    public static void Main(string[] args)
    {
        int n, r, rev = 0, temp;//variable declaration

        Console.Write("Enter the Number: ");
        n = Convert.ToInt32(Console.ReadLine());
        temp = n;//1221
        while (n > 0)
        {
            r = n % 10;//r= 1221 % 10:1   //122%10:2 //12%10:2 //1%10:1
            rev = (rev * 10) + r;//0*10+1=1 // 1*10+2:12 //12*10+2:122 //122*10+1=1221
            n = n / 10;//n=122 //12  //1 //0
        }
        if (temp == rev)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}
