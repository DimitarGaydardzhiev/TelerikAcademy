using System;

namespace MatrixIndexer
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

        //Indexers

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < 0 || colIndex < 0)
                {
                    throw new ArgumentException("rowIndex/colIndex should have positive values!");
                }
                if (rowIndex > rows || colIndex > cols)
                {
                    throw new ArgumentException("rowIndex/colIndex out of matrix range!");
                }
                else
                {
                    return elements[rowIndex, colIndex];
                }
            }
            set
            {
                if (rowIndex < 0 || colIndex < 0)
                {
                    throw new ArgumentException("rowIndex/colIndex should have positive values!");
                }
                if (rowIndex > rows || colIndex > cols)
                {
                    throw new ArgumentException("rowIndex/colIndex out of matrix range!");
                }
                else
                {
                    elements[rowIndex, colIndex] = value;
                }
            }
        }
    }
}
