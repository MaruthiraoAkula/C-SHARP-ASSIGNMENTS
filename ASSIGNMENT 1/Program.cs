
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
            int result;
            int number;
            Console.WriteLine("Enter your Number");

            number = Convert.ToInt32(Console.ReadLine());
            result = number%2;
            if (result == 0)
            {
                Console.WriteLine("Even ");
            }
            else
            Console.WriteLine("odd ");
      

        }
    }
}
