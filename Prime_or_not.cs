using System;

namespace Prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 29;
            if (n <= 1)
            {
                Console.WriteLine("Prime number is not possible ");
            }
            if(n == 2)
            {
                Console.WriteLine("Prime number");
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("Number is not prime");
            }
            for(int i = 3;i * i<= n;i+= 2)
            {
                if(n % 3 == 0)
                {
                    Console.WriteLine("Number is not Prime ");
                }
                else
                {
                    Console.WriteLine("Number is Prime");
                }
            }

        }
    }
}
