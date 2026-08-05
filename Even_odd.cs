using System;

namespace Even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter the random number : ");
            N = Convert.ToInt32(Console.ReadLine());

            for( int i =1;i<= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("The given number is Even: " + i);
                }
                else
                {
                    Console.WriteLine("The given number is Odd: "+ i);
                }
            }
        }
    }
}
