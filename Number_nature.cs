using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_nature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());
            if(a > 0)
            {
                Console.WriteLine("The number "+a+" is positive");
            }
            else if(a < 0)
            {
                Console.WriteLine("The number " + a + " is negative");
            }
            else
            {
                Console.WriteLine("The number " + a + " is Zero");
            }
        }
    }
}
