using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Numbercontain
    {
        public bool IsNumberContain(int num,int digit)
        {
            int inputNum = num;
            while (num > 0)
            {
                if (num % 10 == digit) // 1234 % 10 = 4 ,123 % 10=3,
                {
                    Console.WriteLine("Input Number is {0} ",num);
                    return true;
                }
                num /= 10; // 1234/10=123
            }return false;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = 3;
            Console.WriteLine("Enter numbers");
            
            int num = Convert.ToInt32(Console.ReadLine());
            Numbercontain obj=new Numbercontain();           
            bool res=  obj.IsNumberContain(num, digit);
            Console.WriteLine(res);
        }
    }
}
