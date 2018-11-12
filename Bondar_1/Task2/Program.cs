using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolynomialRef;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p1 = new Polynomial(new double[] { 2, 3 });
            Polynomial p2 = new Polynomial(new double[] { 1, 2 });

            Console.WriteLine((p1 + p2).ToString());
            Console.WriteLine((p1 - p2).ToString());
            Console.WriteLine((p1 * p2).ToString());
            p1.changePower(3);
            Console.WriteLine(p1.ToString());
        }
    }
}
