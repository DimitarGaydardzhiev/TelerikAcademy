using System;

namespace MatrixOperations
{
    public class Matrix<T>
        where T : struct
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
        //Operators overloading
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
            
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The matrix are with different dimensions!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int rows = 0; rows < firstMatrix.Rows; rows++)
            {
                for (int cols = 0; cols < firstMatrix.Cols; cols++)
                {
                    result[rows,cols] = (dynamic)firstMatrix[rows, cols] + (dynamic)secondMatrix[rows, cols];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The matrix are with different dimensions!");
            }
            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int rows = 0; rows < firstMatrix.Rows; rows++)
            {
                for (int cols = 0; cols < firstMatrix.Cols; cols++)
                {
                    result[rows, cols] = (dynamic)firstMatrix[rows, cols] - (dynamic)secondMatrix[rows, cols];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("The matrix are with different dimensions!");
            }
            Matrix<T> multiplicationResult = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
            for (int row1 = 0; row1 < firstMatrix.Rows; row1++)
            {
                for (int col1 = 0; col1 < firstMatrix.Cols; col1++)
                {
                    for (int col2 = 0; col2 < secondMatrix.Cols; col2++)
                    {
                        for (int row2 = 0; row2 < secondMatrix.Rows; row2++)
                        {
                            multiplicationResult[row1, col2] += (dynamic)firstMatrix[row1, col1] * (dynamic)secondMatrix[row2, col2];
                        }
                    }
                }
            }
            return multiplicationResult;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix == null || matrix.Rows == 0 || matrix.Cols == 0)
            {
                return false;
            }

            for (int rows = 0; rows < matrix.Rows; rows++)
            {
                for (int cols = 0; cols < matrix.Cols; cols++)
                {
                    if (matrix[rows,cols].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null || matrix.Rows == 0 || matrix.Cols == 0)
            {
                return true;
            }

            for (int rows = 0; rows < matrix.Rows; rows++)
            {
                for (int cols = 0; cols < matrix.Cols; cols++)
                {
                    if (matrix[rows, cols].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
