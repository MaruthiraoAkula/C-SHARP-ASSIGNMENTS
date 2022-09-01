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
            int[] Arr = new int[3];
            Console.WriteLine("Enter Numbers for Array to sum");//1,2,3
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {     
                int input = Convert.ToInt32(Console.ReadLine());
                Arr[i] = input;
                sum+=Arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
