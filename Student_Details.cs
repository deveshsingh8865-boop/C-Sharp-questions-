using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int Roll_number;
            int Marks;
            Console.WriteLine("Enter the Name of Student :");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Roll Number of student : ");
            Roll_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of the Student : ");
            Marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of the Student is : " + name);
            Console.WriteLine("Student Roll number is : " + Roll_number);
            Console.WriteLine("Student Marks is : " + Marks);
        }
    }
}
