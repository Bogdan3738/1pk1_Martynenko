namespace Task_05_04
{
    internal class Program
    { /*Дан квадратный массив размерность n*n.
       * Произведите анализ данной матрицы и выясните является ли данная матрица
       * диагональной (все элементы вне главной диагонали равны нулю)
       * Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
       * сообщение что матрица не является диагональной. 
       */
        static void Main(string[] args)
        {
            int[,] matrix =
  {
    { 1, 0, 0 },
    { 0, 5, 0 },
    { 0, 0, 7 }
};

            bool isDiagonal = true;
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }
            }

            if (isDiagonal)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(matrix[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной");
            }
        }
    }
}
