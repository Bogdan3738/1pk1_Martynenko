namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
         * 1 столбец содержит нули
         * 2 столбце содержит числа кратные 2
         * 3 столбец содержит числа кратные 3
         * 4 столбец содержит числа кратные 4
         * 5 столбец содержит числа кратные 5
         * Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив 
         */
        static void Main(string[] args)
        {
            int rows = 10, cols = 5;
            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = (i + 1) * (j + 1);
                }
            }

            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            int[,] transposedMatrix = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            Console.WriteLine("Транспонированный массив:");
            PrintMatrix(transposedMatrix);

            void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
