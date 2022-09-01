using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter size of integers");

            int intsize=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter "+intsize+" numbers");
            List<int> list = new List<int>(intsize);
            for (int i = 0; i < intsize; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            List<int> distinct = list.Distinct().ToList();
            var Queryresult = ((from x in distinct orderby x descending select x).Take(5));
            Console.WriteLine("Top 5 ekements :");
            foreach (var item in Queryresult)
            {
                Console.WriteLine(item);
            }
        }
    }
}