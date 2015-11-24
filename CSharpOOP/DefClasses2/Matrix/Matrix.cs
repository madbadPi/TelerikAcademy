namespace Matrix
{
    using System;
    using System.Collections.Generic;

    public class Matrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private const int IniSize = 8;
        
        private T[,] numbers;

        public int Row { get; private set; }
        public int Col { get; private set; }

        public Matrix()
        {
            this.numbers = new T[IniSize, IniSize];
        }

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.numbers = new T[this.Row, this.Col];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Row) || (col < 0 || col >= this.Col))
                {
                    throw new IndexOutOfRangeException("The index is ot of range");
                }
                return this.numbers[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Row) || (col < 0 || col >= this.Col))
                {
                    throw new IndexOutOfRangeException("The index is ot of range");
                }
                this.numbers[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Row, a.Col);
            if (a.Row != b.Row || a.Col != b.Col)
            {
                throw new InvalidOperationException("The two matrices have to be the same size");
            }
            for (int i = 0; i < a.Row; i++)
            {
                for (int j = 0; j < a.Col; j++)
                {
                    result[i, j] = (dynamic)a[i, j] + (dynamic)b[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Row, a.Col);
            if (a.Row != b.Row || a.Col != b.Col)
            {
                throw new InvalidOperationException("The two matrices have to be the same size");
            }
            for (int i = 0; i < a.Row; i++)
            {
                for (int j = 0; j < a.Col; j++)
                {
                    result[i, j] = (dynamic)a[i, j] - (dynamic)b[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Col != b.Row)
            {
                throw new ArgumentException("Matrix size is not the same");
            }
            Matrix<T> result = new Matrix<T>(a.Row, b.Col);
            for (int i = 0; i < a.Row; i++)
            {
                for (int j = 0; j < b.Col; j++)
                {
                    for (int x = 0; x < a.Col; x++)
                    {
                        result[i, j] += (dynamic)a[i, x] * (dynamic)b[x, j];
                    }                   
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> a)
        {
            foreach (var item in a.numbers)
            {
                if ((dynamic)item != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> a)
        {
            foreach (var item in a.numbers)
            {
                if ((dynamic)item != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    if (j != this.Col - 1)
                    {
                        result = result + " " + this.numbers[i, j];
                    }
                    else
                    {
                        result = result + " " + this.numbers[i, j] + Environment.NewLine;
                    }
                }
            }
            return result;
        }
    }
}
