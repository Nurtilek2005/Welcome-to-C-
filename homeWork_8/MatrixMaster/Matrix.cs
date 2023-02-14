using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace MatrixMaster
{
    public class Matrix<T>
    {
        private T[,] storage;
        private int rows, columns;

        // Здесь ошибки нужно обрабатывать?
        public T this[int row, int column]
        {
            get
            {
                return storage[row, column];
            }
            
            set
            {
                storage[row, column] = value;
            }
        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            storage = new T[this.rows, this.columns];
        }

        public bool IsPointExists(int row, int column)
        {
            if (row >= rows || row < 0) return false;
            if (column >= columns || column < 0) return false;
            return true;
        }

        public void SetValue(T value, int row, int column)
        {
            if (value == null) return;
            if (row >= rows || row < 0) return;
            if (column >= columns || column < 0) return;
            storage[row, column] = value;
        }

        public T? GetValue(int row, int column)
        {
            if (row >= rows || row < 0) return default(T);
            if (column >= columns || column < 0) return default(T);
            return storage[row, column];
        }

        public T[] GetRowArray(int row)
        {
            T[] rowArr = new T[columns];
            if (row >= rows || row < 0) return rowArr;
            for (int i = 0; i < columns; i++)
            {
                rowArr[i] = storage[row, i];
            }
            return rowArr;
        }

        public T[] GetColumnArray(int column)
        {
            T[] columnArr = new T[rows];
            if (column >= columns || column < 0) return columnArr;
            for (int i = 0; i < rows; i++)
            {
                columnArr[i] = storage[i, column];
            }
            return columnArr;
        }

        public void RandomNumbers(int lowerBound, int upperBound)
        {
            Random random = new Random();
            for (int i = 0; i < GetRowsLength(); i++)
            {
                for (int j = 0; j < GetColumnsLength(); j++)
                {
                    storage.SetValue(random.Next(lowerBound, (upperBound + 1)), i, j);
                }
            }
        }

        public void RandomDoubles(int lowerBound, int upperBound)
        {
            Random random = new Random();
            for (int i = 0; i < GetRowsLength(); i++)
            {
                for (int j = 0; j < GetColumnsLength(); j++)
                {
                    int randNum = random.Next(lowerBound, upperBound);
                    double randDouble = randNum + random.NextDouble();
                    storage.SetValue(Math.Round(randDouble, 1), i, j);
                }
            }
        }
        public Matrix<int> Duplicate()
        {
            Matrix<int> duplicate = new Matrix<int>(rows, columns);
            for (int i = 0; i < GetRowsLength(); i++)
            {
                for (int j = 0; j < GetColumnsLength(); j++)
                {
                    int tempNum = Convert.ToInt32(storage[i, j]);
                    duplicate.SetValue(tempNum, i, j);
                }
            }
            return duplicate;
        }

        public Matrix<int> GetSortedNums(bool ascending = true)
        {
            Matrix<int> sortedMatrix = Duplicate();
            for (int row = 0; row < rows; row++)
            {
                for (int i = 0; i < columns; i++)
                {
                    int tempMax = Convert.ToInt32(sortedMatrix.GetValue(row, i));
                    for (int j = 0; j <= columns - 1; j++)
                    {
                        int tempNum = Convert.ToInt32(sortedMatrix.GetValue(row, j));
                        if (tempMax > tempNum && !ascending)
                        {
                            tempMax = sortedMatrix.GetValue(row, i);
                            sortedMatrix.SetValue(tempNum, row, i);
                            sortedMatrix.SetValue(tempMax, row, j);
                        }
                        else if (tempMax < tempNum && ascending)
                        {
                            tempMax = sortedMatrix.GetValue(row, i);
                            sortedMatrix.SetValue(tempNum, row, i);
                            sortedMatrix.SetValue(tempMax, row, j);
                        }
                    }
                }
            }
            return sortedMatrix;
        }

        public override string ToString()
        {
            string strMatrix = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    strMatrix += storage[i, j] + "\t";
                }
                strMatrix += storage[i, columns - 1];
                if (i < (rows - 1)) strMatrix += "\n";
            }
            return strMatrix;
        }

        public int GetRowsLength() { return rows; }
        public int GetColumnsLength() { return columns; }
    }
}
