using System;

namespace Matrix
{
    public class Matrix<T>
    {
        private const int DefaultSize = 16;
        private int rows;
        private int cols;
        private T[,] elements;

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        //Constructors
        public Matrix()
        {
            elements = new T[DefaultSize, DefaultSize];
        }

        public Matrix(int Rows, int Cols)
        {
            if (Rows < 0 || Cols < 0)
            {
                throw new ArgumentException("Rows and Cols should have positive values!");
            }

            this.rows = Rows;
            this.cols = Cols;

            elements = new T[rows, cols];
        }
    }
}
