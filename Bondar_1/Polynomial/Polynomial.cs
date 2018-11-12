using System;

namespace PolynomialRef
{
    public class Polynomial
    {
        private int power;
        private int Power
        {
            get { return power; }
            set
            {
                if (value < 0)
                    throw new Exception("Power of polinom should be not negative and integer number");
                else
                    power = value;
            }
        }

        private double[] coefficients;
        private double[] Coefficients
        {
            get { return coefficients; }
            set { coefficients = value; }
        }

        public Polynomial()
        {
            power = 1;
            coefficients = new double[1] { 1 };
        }

        public Polynomial(double[] coef)
        {
            power = coef.GetLength(0)-1;
            coefficients = coef;
        }

        public Polynomial(int pow, double[] coef)
        {
            power = pow;
            coefficients = coef;
        }

        public void changeCoef(int index, double temp)
        {
            if (!(index >= 0 && index < coefficients.GetLength(0)))
                throw new Exception("Index out of range");

            coefficients[index] = temp;
        }

        public double getCoef(int index)
        {
            if (!(index >= 0 && index < coefficients.GetLength(0)))
                throw new Exception("Index out of range");

            return coefficients[index];
        }

        public void changePower(int pow)
        {
            if (pow < 1)
                throw new Exception("Index out of range");
            Polynomial temp = this;
            for (int i = 0; i < coefficients.GetLength(0); i++)
                temp *= this;
            this.coefficients = temp.coefficients;
        }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            double[] c;
            if (a.coefficients.GetLength(0) > b.coefficients.GetLength(0))
                c = new double[a.coefficients.GetLength(0)];
            else
                c = new double[b.coefficients.GetLength(0)];

            for (int i = 0; i < c.GetLength(0); i++)
            {
                c[i] = a.coefficients[i] + b.coefficients[i];
            }
            return new Polynomial(c);
        }

        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            double[] c;
            if (a.coefficients.GetLength(0) > b.coefficients.GetLength(0))
                c = new double[a.coefficients.GetLength(0)];
            else
                c = new double[b.coefficients.GetLength(0)];

            for (int i = 0; i < c.GetLength(0); i++)
            {
                c[i] = a.coefficients[i] - b.coefficients[i];
            }
            return new Polynomial(c);
        }

        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            double[] c;
            c = new double[b.coefficients.GetLength(0) + a.coefficients.GetLength(0) - 1];

            for (int i = 0; i < a.coefficients.GetLength(0); ++i)
            {
                for (int j = 0; j < b.coefficients.GetLength(0); ++j)
                {
                    c[i + j] += a.coefficients[i] * b.coefficients[j];
                }
            }
            return new Polynomial(c);
        }

        public override string ToString()
        {
            String temp = "";
            for (int i = 0; i < coefficients.GetLength(0); i++)
                temp += coefficients[i]+"x^" + i + " + ";
            return temp;
        }
    }
}