using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ArithmeticOperations
    {
        public int Addition(int a, int b)
        {
            return (a + b);

        }
        public int Subs(int a, int b)
        {
            return (a - b);

        }
        public int multiply(int a, int b)
        {
            return (a * b);

        }
        public int Division(int a, int b)
        {
            return (a / b);

        } 
    }



    internal class Program
    {
        static void Main(string[] args)
        {
           ArithmeticOperations obj = new ArithmeticOperations();
           Console.WriteLine("Enter one integer ");

           int num1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Second interger for ArithemeticOperations");

           int num2 = Convert.ToInt32(Console.ReadLine());


           int addRes = obj.Addition(num1, num2);
           int subsRes = obj.Subs(num1, num2);
           int multiplyRes = obj.multiply(num1, num2);
           int DivisionRes =  obj.Division(num1, num2);
           Console.WriteLine(addRes + " , " + subsRes + " , " + multiplyRes + " , " + DivisionRes);
        }
    }
}
