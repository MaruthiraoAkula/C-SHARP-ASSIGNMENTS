using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> Arr = new List<int>();
            Console.WriteLine("Enter Numbers for Array to sum and Zero for exit");

            int input =Convert.ToInt32(Console.ReadLine());
            while (input > 0)
            {
                Arr.Add(input);
                input = Convert.ToInt32(Console.ReadLine());
                sum = Arr.Take(3).Sum();
            }
            Console.WriteLine(sum);
        }
    }
}
