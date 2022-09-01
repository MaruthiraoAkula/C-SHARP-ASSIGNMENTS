using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the bit number ");//10010<--18
            
            string num = Console.ReadLine();
            int ans = 0;           
            ans = Convert.ToInt32(num, 2);
            Console.WriteLine(ans);

        }
    }
}
