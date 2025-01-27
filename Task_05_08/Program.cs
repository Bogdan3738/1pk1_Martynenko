namespace Task_05_08
{
    internal class Program
    {
        /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл.
         * Создать новый массив, который будет
         * произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
         * результирующий массив)
         * Вывести результирующий массив 
         */
        static void Main(string[] args)
        {
            static void PrintMatrix(int[,] matrix)
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

            static void PrintMatrixWithHighlights(int[,] matrix, int[] highlights)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (Array.Exists(highlights, element => element == matrix[i, j]))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
