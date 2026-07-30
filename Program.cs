//Write a program of compute the sum of first N numbers (without using loop)
using System;
using System.Runtime.ExceptionServices;
namespace DeveshConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num;
            Console.WriteLine("Ente the Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum = (num * (num + 1) / 2);
            Console.WriteLine("The Sum of N numbers :"+sum);
        }
    }
}
