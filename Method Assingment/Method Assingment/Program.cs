using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 20, c, d, e;
            MathOps Operation = new MathOps();
            Console.WriteLine("Enter any number:");

            a = Convert.ToInt32(Console.ReadLine());
            c = Operation.Sum(a, b);
            d = Operation.Subtract(a, b);
            e = Operation.Multiply(a, b);

            Console.WriteLine("Sum =" + c);
            Console.WriteLine("Difference =" + d);
            Console.WriteLine("Product =" + e);

            Console.ReadLine();
        }
    }
}
