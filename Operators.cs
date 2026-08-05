using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Addition of two Numbers is: " + (a + b));
            Console.WriteLine("The Product of two numbers is: " + (a * b));
            Console.WriteLine("The difference of two numbers is : " + (a - b));
            Console.WriteLine("The quotient of two numbers is: " + (a / b));
            Console.WriteLine("The remiander of two numbers is : " + (a % b));
        }
    }
}
