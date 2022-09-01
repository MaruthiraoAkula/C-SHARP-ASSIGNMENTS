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

            int num = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            while (num > 0)
            {
                list.Add(num);

                num = Convert.ToInt32(Console.ReadLine());              
            }
            List<int> distinct = list.Distinct().ToList();
            var Queryresult = ((from x in distinct orderby x descending select x).Take(5));
            Console.WriteLine("Top 5 Elements :");
            foreach (var item in Queryresult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
