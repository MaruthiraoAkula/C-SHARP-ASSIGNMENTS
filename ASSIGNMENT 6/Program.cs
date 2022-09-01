using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string of two letters");
            string twoLetters=Console.ReadLine();
            string output = "";
            for (char i = twoLetters[0]; i <= twoLetters[1]; i++)
            {
                output += i;
            }
            Console.WriteLine(output);
        }
    }
}
