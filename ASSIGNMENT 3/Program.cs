using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Sorted
    {
        public  bool Method(params int[] Arrr)
        {
            int j;
            bool flag1 = false;
          //bool flag2 = false;
            for (j = 1; j < Arrr.Length; j++)
            {
                if (Arrr[j-1] < Arrr[j])
                {
                    flag1 = true;
                }
               /* if (Arrr[j - 1] > Arrr[j])
                {
                    flag2 = true;
                }*/
            }
            if (flag1)
            {
                return true;
            }
             /*if (flag1 && !flag2)
              {
                  return true;
              }
              if (!flag1 && flag2)
              {
                  return true;
              }*/
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Three Intergers for Array");
            int[] Arr = new int[3];
            for (int i=0;i<Arr.Length;i++)
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                Arr[i]=Number;
            }
            Sorted obj=new Sorted();
            Console.WriteLine(obj.Method(Arr));

        }
    }
}
