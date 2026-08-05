using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int digt=0;
            int sum = 0;
            while(n > 0)
            {
                digt =  n % 10;
                sum = sum * 10 + digt;
                n = n / 10;
            }
            if ( temp == sum)
            {
                Console.WriteLine("The number is  palindrome ");
            }
            else
            {
                Console.WriteLine("The given number is not a palindrome");
            }
        }
    }
}
