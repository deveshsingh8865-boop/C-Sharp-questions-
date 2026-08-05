using System;
namespace Student_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the marks :");
            a = Convert.ToInt32(Console.ReadLine());
            if(a <= 100  && a >= 91)
            {
                Console.WriteLine("The grade is : O");
            }
            else if(a >= 81 && a <= 90)
            {
                Console.WriteLine("The grade is : A+");
            }
            else if(a >= 71 && a <= 80)
            {
                Console.WriteLine("The grade is : A");
            }
            else if(a >= 61 && a <= 70)
            {
                Console.WriteLine("The grade is : B+");
            }
            else if(a >= 51 && a <= 60)
            {
                Console.WriteLine("The grade is : B");
            }
            else
            {
                Console.WriteLine("The Student is fail in the exam: ");
            }
        }
    }
}
