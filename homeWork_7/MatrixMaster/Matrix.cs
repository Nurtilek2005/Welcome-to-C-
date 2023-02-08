namespace MatrixMaster
{
    public class Matrix<T>
    {
        private T[,] storage;
        private int rows, columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            storage = new T[this.rows, this.columns];
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

        public override string ToString()
        {
            string strMatrix = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    strMatrix += storage[i, j] + " ";
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
