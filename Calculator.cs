using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter the number a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number c:");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1: Console.WriteLine("The addition is "+ (a+b)); 
                    break;
                case 2: Console.WriteLine("The difference is" + (a - b));
                    break;
                case 3: Console.WriteLine("The product is : " + (a * b));
                    break;
                case 4: Console.WriteLine("The division is : " + (a / b));
                    break;

            }
        }
    }
}
