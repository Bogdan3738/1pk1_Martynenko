﻿namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните
         * является ли данная матрица Z-матрицей
         * (это матрица, где все недиагональные элементы меньше нуля)
         * Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
         * вывести сообщение что данная матрица не является Z-матрицей 
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                }
            }

            Console.WriteLine("\nСгенерированная матрица:");
            PrintMatrix(matrix);

            bool isZMatrix = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] >= 0)
                    {
                        isZMatrix = false;
                        break;
                    }
                }
                if (!isZMatrix) break;
            }

            if (isZMatrix)
            {
                Console.WriteLine("\nМатрица является Z-матрицей. С цветовой индикацией главной диагонали:");
                PrintMatrixWithDiagonalHighlight(matrix);
            }
            else
            {
                Console.WriteLine("\nМатрица не является Z-матрицей.");
            }

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

            void PrintMatrixWithDiagonalHighlight(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ResetColor();
                        }
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
            }
        }
    }
}
