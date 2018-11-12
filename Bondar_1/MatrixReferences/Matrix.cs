using System;

namespace MatrixReferences
{
    public class Matrix : ICloneable
    {
        private int[,] m_matrix;

        public int[,] matrix
        {
            get { return m_matrix; }
            set { m_matrix = value; }
        }

        public Matrix()
        {
            m_matrix = new int[2, 2] { { 1, 1 }, { 1, 1 } };
        }

        public Matrix(int[,] arr)
        {
            m_matrix = arr;
        }

        public int this[int i, int j]
        {
            get { return m_matrix[i, j]; }
            set { m_matrix[i, j] = value; }
        }

        public object Clone()
        {
            return new Matrix { m_matrix = this.matrix };
        }

        /*public int toString()
        {
            
            return m_matrix.GetLength(0);
        }*/

        public override string ToString()
        {
            string retVal = null;
            foreach (int element in m_matrix)
            {
                retVal += element.ToString() + " ";
            }

            return retVal;

        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.m_matrix.GetLength(0) != b.m_matrix.GetLength(0) && a.m_matrix.GetLength(1) != b.m_matrix.GetLength(1))
                throw new OperationNotAcceptableException("Matrix dimensions should be equal to perform this operation");
            int[,] c = new int[a.m_matrix.GetLength(0), a.m_matrix.GetLength(1)];

            for (int i = 0; i < a.m_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.m_matrix.GetLength(1); j++)
                {
                    c[i, j] = a.m_matrix[i, j] + b.m_matrix[i, j];
                }
            }

            return new Matrix(c);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.m_matrix.GetLength(0) != b.m_matrix.GetLength(0) && a.m_matrix.GetLength(1) != b.m_matrix.GetLength(1))
                throw new OperationNotAcceptableException("Matrix dimensions should be equal to perform this operation");
            int[,] c = new int[a.m_matrix.GetLength(0), a.m_matrix.GetLength(1)];

            for (int i = 0; i < a.m_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.m_matrix.GetLength(1); j++)
                {
                    c[i, j] = a.m_matrix[i, j] - b.m_matrix[i, j];
                }
            }

            return new Matrix(c);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.m_matrix.GetLength(0) != b.m_matrix.GetLength(1) || a.m_matrix.GetLength(1) != b.m_matrix.GetLength(0))
                throw new OperationNotAcceptableException("Matrix opposing dimensions should be equal to perform this operation");
            int[,] c = new int[a.m_matrix.GetLength(0), a.m_matrix.GetLength(1)];

            for (int i = 0; i < a.m_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < b.m_matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < a.m_matrix.GetLength(1); k++)
                    {
                        c[i, j] += a.m_matrix[i, k] * b.m_matrix[k, j];
                    }
                }
            }

            return new Matrix(c);
        }
    }
}
