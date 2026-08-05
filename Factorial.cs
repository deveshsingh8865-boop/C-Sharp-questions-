using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int f = 1;
            for (int i = 0;i < n; i++)
            {
                f = f * (n - i);
                //Console.WriteLine("The factorial of the given number is : " + f);
            }
            Console.WriteLine("The factorial of the given number is : " + f);

        }
    }
}
