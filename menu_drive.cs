using System;

namespace Menu_driven
{
    internal class Program
    {
        void checkEven_Odd()
        {
            int n;
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("The Given Number is :" + n + " even.");
            }
            else
            {
                Console.WriteLine("The given Nummber is : " + n + " odd.");
            }
        }
        void Largest_number()
        {
            int a, b, c;
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " Is the largest number!");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " Is the largest number!");
            }
            else
            {
                Console.WriteLine(c + " Is the largest number!");
            }
        }
        void factorial()
        {
            int num;
            Console.WriteLine("Give some number for factorial: ");
            num = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            while (num > 0)
            {

                Fact = Fact * num;
                num--;
            }
            Console.WriteLine("The factoria of the given number is : " + Fact);
        }
        public static void Main1(string[] args)
        {
            Program ob = new Program();
            ob.checkEven_Odd();
            ob.factorial();
        }
    }
}
