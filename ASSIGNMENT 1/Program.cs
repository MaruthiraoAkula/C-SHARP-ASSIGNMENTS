using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Number");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine("Even ");
            }
            else
            Console.WriteLine("odd "); 
        }
    }
}
