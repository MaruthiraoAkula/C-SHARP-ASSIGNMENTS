using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one Number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flg=true;
            for(int i = 2; i<=num/2; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine(" not a prime number");
                    flg = false;
                    break;
                }   
            }
            if (flg)
            {
                Console.WriteLine("prime number");                
            }
        }
    }
}
