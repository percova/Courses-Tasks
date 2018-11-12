using System;
using MatrixReferences;

namespace Practice1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix(new int[,] { { 1, 2 }, { 3, 4 } });
            Matrix m4 = new Matrix(new int[,] { { 1, 2,4  }, { 3, 4, 4 }, {5, 6, 4} });
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            m1 = (Matrix)m2.Clone();
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());

            Matrix m3 = new Matrix();
            m3 = m1 + m2;
            Console.WriteLine(m3.ToString());

            m3 = m2 - m1;
            Console.WriteLine(m3.ToString());

            m3 = m1 * m2;
            Console.WriteLine(m3.ToString());
            //Console.WriteLine((m1 + m4).ToString());
            //Console.WriteLine((m1 - m4).ToString());
            Console.WriteLine((m1 * m4).ToString());
        }
    }
}