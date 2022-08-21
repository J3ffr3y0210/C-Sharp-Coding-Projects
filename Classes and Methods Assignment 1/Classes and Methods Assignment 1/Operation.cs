using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    class Operation
    {
        public int sum()
        {
            int a, b = 16;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            return (a + b);
        }
        public decimal Multiply()
        {
            decimal c, d = 16;
            Console.WriteLine("Enter a decimal number:");
            c = Convert.ToDecimal(Console.ReadLine());
            return decimal.Multiply(c, d);
        }
        public int Add()
        {
            string e = "16";
            Console.WriteLine("Enter a number: ");
            String f = Console.ReadLine();
            int g = Convert.ToInt32(e);
            int h = Convert.ToInt32(f);
            return (g + h);

            Console.ReadLine();
        }
    }
}
